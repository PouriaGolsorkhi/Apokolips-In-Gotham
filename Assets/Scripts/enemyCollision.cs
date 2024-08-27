using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullets"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            
        }
    }
}
