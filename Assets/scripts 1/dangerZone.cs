using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dangerZone : MonoBehaviour
{
    public bool playerIn;
    public bool MGin;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIn = true;
        }
        if (other.gameObject.tag == "MG")
        {
            MGin = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerIn = false;

        }
        if (other.gameObject.tag == "MG")
        {
            MGin = false;
        }

    }
}
