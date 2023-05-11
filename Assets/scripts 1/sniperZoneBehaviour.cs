using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperZoneBehaviour : MonoBehaviour
{
    sniperDotBehaviour SDB;

    private void Start()
    {
        SDB = GameObject.FindGameObjectWithTag("tag A").GetComponent<sniperDotBehaviour>();
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SDB.track(gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SDB.Reset(gameObject);
        }
    }
}
