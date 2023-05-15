using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private IEnumerator damageCoroutine;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dot")
        {
            Debug.Log("Player is in dot");
            damageCoroutine = TakeDamageAfterDelay();
                StartCoroutine(damageCoroutine);
            
        }
    }

    private IEnumerator TakeDamageAfterDelay()
    {
        yield return new WaitForSeconds(3f);
        GameManager.TakeDamage(20);
        Debug.Log("Player took damage");
    }
}
