using UnityEngine;
using System.Collections;

public class bombZone : MonoBehaviour
{
    public GameObject bombPrefab;
    public GameObject bomb;
    private bool playerinTrigger;
    [SerializeField]private GameObject player;

    private void Update()
    {
        bomb = GameObject.FindGameObjectWithTag("bomb");
        if (!bomb && playerinTrigger)
        {
            SpawnBombs(player.transform.position);
            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        playerinTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        playerinTrigger = false;
    }
    
    private void SpawnBombs(Vector3 position)
    {
            GameObject bomb = Instantiate(bombPrefab, position, Quaternion.identity);
            Destroy(bomb, 1.0f);
        

    }
}
