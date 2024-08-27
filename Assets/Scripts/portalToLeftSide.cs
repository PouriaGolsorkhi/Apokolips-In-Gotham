using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalToLeftSide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Vector3 newPos = new Vector3(-5.8f, other.transform.position.y, other.transform.position.z);
        other.transform.position = newPos; 

    }

}
