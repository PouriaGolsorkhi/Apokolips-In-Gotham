using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalToLowerSide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Vector3 newPos = new Vector3(other.transform.position.x,-6.8f , other.transform.position.z);
        other.transform.position = newPos;

    }
}
