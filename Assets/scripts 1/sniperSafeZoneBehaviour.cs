using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperSafeZoneBehaviour : MonoBehaviour
{

    sniperDotBehaviour SDB;


    private void Start()
    {
        SDB = GameObject.FindGameObjectWithTag("Dot").GetComponent<sniperDotBehaviour>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player in safezone");
            SDB.Reset(gameObject);
        }
    }

}
