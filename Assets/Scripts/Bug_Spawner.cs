using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug_Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] bugPrefabs;
    public GameObject[] ratPrefabs;
    public GameObject snake;
    float SpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTime=(PlayerPrefs.GetInt("Badge",0))/100f;
        if(SpawnTime>9f)
            SpawnTime=9f;
        Invoke("bugspawn",0.5f);
        Invoke("ratspawn",4.5f);
        Invoke("snakespawn",(10f-SpawnTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void bugspawn()
    {
        int randEnemy=Random.Range(0,bugPrefabs.Length);
        int randSpawnPoint=Random.Range(0,spawnPoints.Length);

        Instantiate(bugPrefabs[randEnemy],spawnPoints[randSpawnPoint].position,transform.rotation);
        Invoke("bugspawn",0.5f);
    }

    public void ratspawn()
    {
        int randEnemy=Random.Range(0,ratPrefabs.Length);
        int randSpawnPoint=Random.Range(0,spawnPoints.Length);

        Instantiate(ratPrefabs[randEnemy],spawnPoints[randSpawnPoint].position,transform.rotation);
        Invoke("ratspawn",4.5f);
    }

    public void snakespawn()
    {
        int randSpawnPoint=Random.Range(0,spawnPoints.Length);
        
        Instantiate(snake,spawnPoints[randSpawnPoint].position,transform.rotation);
        Invoke("snakespawn",(10f-SpawnTime));
    }
}
