using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class deadsoldier : MonoBehaviour
{
    public GameObject Dialog;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("player in soldier zone");
        Dialog.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("player left soldier zone");
        Dialog.SetActive(false);
    }
}
