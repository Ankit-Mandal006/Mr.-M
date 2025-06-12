using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magma_Spawn : MonoBehaviour
{
    public GameObject[] sp;
    public GameObject[] magma1;
    public GameObject[] magma2;
    //public string method;
    float SpawnTime;
    public Timer time;
    // Start is called before the first frame update
    void Start()
    {
       // time=GetComponent<Timer>();
        SpawnTime=(PlayerPrefs.GetInt("Badge",0))/100f;
        if(SpawnTime>5f)
            SpawnTime=5f;
        time.startingTime=time.startingTime+(SpawnTime*2);
      Magma();
    }

    void Magma()
    {
        int s=Random.Range(0,2);
        if(s==0)
            Instantiate(magma1[Random.Range(0,magma1.Length)],sp[s].transform.position,this.transform.rotation);
        else
            Instantiate(magma2[Random.Range(0,magma2.Length)],sp[s].transform.position,this.transform.rotation);
        Invoke("Magma",Random.Range((6f-SpawnTime),(8f-SpawnTime)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
