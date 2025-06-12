using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainMagma_Spawner : MonoBehaviour
{
    public GameObject[] sp;
    GameObject a;
    public GameObject[] magma;
    float SpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTime=(PlayerPrefs.GetInt("Badge",0))/100f;
        if(SpawnTime>10f)
            SpawnTime=10f;
        Invoke("Magma",Random.Range((12.25f-SpawnTime),(15f-SpawnTime)));
    }
    public void Magma()
    {
        int randEnemy=Random.Range(0,magma.Length);
        float r=Random.Range((12.25f-SpawnTime),(15f-SpawnTime));
        a=Instantiate(magma[randEnemy],sp[Random.Range(0,sp.Length)].transform.position,this.transform.rotation);
        Invoke("Magma",r);
        Invoke("dest",3f);
    }
    public void dest()
    {
        Destroy(a.gameObject);
    }
}