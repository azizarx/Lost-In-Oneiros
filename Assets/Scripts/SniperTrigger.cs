using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperTrigger : MonoBehaviour
{
    
    sniperDotBehaviour SDB;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        SDB = GameObject.FindGameObjectWithTag("Dot").GetComponent<sniperDotBehaviour>();
    }
    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player in sniper zone");
            SDB.track(gameObject);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")){
            Debug.Log("player left sniper zone");
            SDB.Reset(gameObject);
        }
        
        
    }
    
}
