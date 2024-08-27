using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossCollision : MonoBehaviour
{
    int bossHealthcount = 10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullets"))
        {
            bossHealthcount--;
            if (bossHealthcount == 0)
            {
                Destroy(gameObject);

            }
            
            Destroy(other.gameObject);

        }
    }
}
