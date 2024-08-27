using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class managingLevel3 : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject player;
    public float attackSpeed = 2f;
    Vector3 directionToPlayer;
    public GameObject completeLevelui;


    GameObject[] enemiesHolder = new GameObject[24];

    GameObject spawnPrefInstance(Vector3 sp, Quaternion dr)
    {
        GameObject newInstance = Instantiate(myPrefab, sp, dr);
        return newInstance;
    }
    void Start()
    {
        for (int i = 0; i < 24; i++)
        {
            float rndx = UnityEngine.Random.Range(-4f, 4f);
            float rndy = UnityEngine.Random.Range(2f, 5.5f);
            Vector3 SpawnPos = new Vector3(rndx, rndy, 0f);
            Quaternion desiredRotation = Quaternion.Euler(0f, 0f, -30f);
            enemiesHolder[i] = spawnPrefInstance(SpawnPos, desiredRotation);
            enemiesHolder[i].GetComponent<SpriteRenderer>().sortingLayerName = "enemy";
            enemiesHolder[i].GetComponent<SpriteRenderer>().sortingOrder = -15;

        }

    }
    private void Update()
    {
        int counter = 24;
        for (int i = 0; i < enemiesHolder.Length; i++)
        {
            if (enemiesHolder[i] != null && player != null)
            {
                directionToPlayer = (player.transform.position - enemiesHolder[i].transform.position).normalized;
                enemiesHolder[i].transform.Translate(directionToPlayer * attackSpeed * Time.deltaTime);
            }
            else
            {
                counter--;
            }

        }
        if (counter == 0 && player != null)
        {
            completeLevelui.SetActive(true);


            FindObjectOfType<EndGame>().LevelComplete();

        }






    }








}
