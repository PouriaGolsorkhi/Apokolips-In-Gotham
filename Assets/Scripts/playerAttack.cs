using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerAttack : MonoBehaviour
{
    public GameObject bulletPref;
    public Transform batWing;
    public float shootingForce = 5000;

    float nextUpdatetime;
    float gapBetweenUpdates = 0.7f;

    private void Start()
    {
        nextUpdatetime = Time.time + gapBetweenUpdates;
    }
    void Update()
    {
        
        
            if (Input.GetKey("l") && Time.time >= nextUpdatetime)
            {
            
                Vector3 spawnPos = new Vector3(batWing.position.x, batWing.position.y + 1.12f , batWing.position.z);
                quaternion rotation = Quaternion.Euler(0, 0, 0);
                GameObject newBullet = Instantiate(bulletPref,spawnPos,rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(0f,shootingForce * Time.deltaTime ,0f, ForceMode.VelocityChange );
                nextUpdatetime = Time.time+ gapBetweenUpdates;
            }
            
            
            

        
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }
}
