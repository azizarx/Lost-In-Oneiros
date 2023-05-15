using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperDotBehaviour : MonoBehaviour
{
    public Transform objectToFollow;
    public Vector3 offset;
    public float followSpeed = 50f; // The speed at which the dot should follow the player

    void Start()
    {
        //PB = GameObject.FindGameObjectWithTag("tag A").GetComponent<playerBehaviour>();
    }

    public void track(GameObject g)
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(objectToFollow.position.x,objectToFollow.position.y,0) + offset, followSpeed * Time.deltaTime);
       
    }

    public void Reset(GameObject g)
    {
        // Get a random point within a unit circle
       

        // Set the position of the dot to a small distance away from its last position, in a random direction
        transform.position = new Vector3(999, 999, 999);
    }

    


}