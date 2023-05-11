using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineGunAnchor : MonoBehaviour
{
    public dangerZone zone;
    public Transform startPos;
    public GameObject player;
    private Vector2 newZomPos;
    private float speed = 4.0f;

    public float rotateSpeed = 100f; // rotation speed
    public float maxTimeBetweenDirectionChanges = 2f; // maximum time between changes in direction

    private float timeSinceLastDirectionChange; // time since the last direction change
    private Vector2 direction;
    // Update is called once per frame
    private void Start()
    {
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    void Update()
    {
        if (zone.playerIn)
        {
            newZomPos = new Vector2(player.transform.position.x, player.transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, newZomPos, speed * Time.deltaTime);

        }
        else if (!zone.playerIn&&zone.MGin)
        {

            timeSinceLastDirectionChange += Time.deltaTime;

            // if it's time to change direction, pick a new random direction
            if (timeSinceLastDirectionChange > maxTimeBetweenDirectionChanges)
            {
                direction = new Vector2(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f)).normalized;
                timeSinceLastDirectionChange = 0f;
            }

            // move the object in the current direction
            transform.position += (Vector3)direction * speed * Time.deltaTime;

            // rotate the object to face the direction of movement
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, angle), rotateSpeed * Time.deltaTime);

        }
        else if (!zone.MGin)
        {
            transform.position = Vector2.MoveTowards(transform.position, startPos.position, speed * Time.deltaTime);
        }
    }
}

