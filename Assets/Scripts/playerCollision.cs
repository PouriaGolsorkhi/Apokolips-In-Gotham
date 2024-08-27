using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public GameObject gameoverpanel;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            gameoverpanel.SetActive(true);
            Destroy(gameObject);
        }
    }
}
