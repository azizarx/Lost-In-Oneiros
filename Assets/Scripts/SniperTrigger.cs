using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperTrigger : MonoBehaviour
{
    private bool playerInTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInTrigger)
        {
            Debug.Log("player in sniper zone");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        playerInTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("player left sniper zone");
        playerInTrigger = false;
    }
}
