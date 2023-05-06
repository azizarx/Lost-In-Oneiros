using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public Rigidbody body;
    public SpriteRenderer spriteRenderer;
    public float walkSpeed;
    public float frameRate;
    public List<Sprite> nSprites;
    public List<Sprite> neSprites;
    public List<Sprite> eSprites;
    public List<Sprite> seSprites;
    public List<Sprite> sSprites;
    float idleTime;
    
    Vector2 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
        body.velocity = direction * walkSpeed;
        HandleSpriteFlip();
        List<Sprite> directionSprites = GetSpriteDirection();
       if(directionSprites != null)
        {
            //holding direction
            float playTime = Time.time - idleTime;
            int totalFrames = (int)(playTime * frameRate);
            int frame = totalFrames % directionSprites.Count;
            spriteRenderer.sprite = directionSprites[frame];

        }
        else
        {
            idleTime = Time.time;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            walkSpeed *= 2;
            frameRate *= 2;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
             walkSpeed /= 2;
            frameRate /= 2;
        }
           

    }
   void HandleSpriteFlip()
    {
        if(!spriteRenderer.flipX && direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }else if(spriteRenderer.flipX && direction.x > 0)
        {
            spriteRenderer.flipX = false;
        }
    }
    List<Sprite> GetSpriteDirection()
    {
        List<Sprite> selectSprites = null;
        if (direction.y > 0)
        {
            if (Mathf.Abs(direction.x) > 0)
            {
                selectSprites = neSprites;
            }
            else
            {
                selectSprites = nSprites;
            }
        }
        else if (direction.y < 0)
        {
            if (Mathf.Abs(direction.x) > 0)
            {
                selectSprites = seSprites;
            }
            else
            {
                selectSprites = sSprites;
            }
        }
        else
        {
            if (Mathf.Abs(direction.x) > 0)
            {
                selectSprites = eSprites;
            }
        }
        return selectSprites;
    }

}
