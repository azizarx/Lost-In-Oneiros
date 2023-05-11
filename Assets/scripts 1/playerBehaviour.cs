using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{

    public unitHealth playerHealth = new unitHealth(100, 100);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    /*    if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerTakeDmg(20);
            Debug.Log(GameManager.gameManager.playerHealth.Health);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerTakeDmg(20);
            Debug.Log(GameManager.gameManager.playerHealth.Health);
        }
    */
    }

    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager.playerHealth.DmgUnit(dmg);
    }
    private void PlayerHealDmg(int healing)
    {
        GameManager.gameManager.playerHealth.DmgUnit(healing);
    }

}
