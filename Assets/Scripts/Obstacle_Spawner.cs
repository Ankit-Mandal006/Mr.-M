using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Spawner : MonoBehaviour
{
    public GameObject[] obs;
    public GameObject win;
    float r1;
    float SpawnRate;
    public Timer time;
    // Start is called before the first frame update
    void Awake()
    {
        //time=GetComponent<Timer>();
        SpawnRate=(int)(PlayerPrefs.GetInt("Badge",0)/10)+5;
        if(SpawnRate>25)
            SpawnRate=25;
        time.startingTime=time.startingTime+SpawnRate;
        r1=0f;
        for(int i=0;i<15;i++)
        {
            r1=Random.Range(r1+10f,r1+15f);
            Vector3 coodinates=new Vector3((float)r1,0,0);
            Instantiate(obs[Random.Range(0,obs.Length)],(coodinates),transform.rotation);
            if(i==14)
                Instantiate(win,new Vector3((float)r1+7.5f,0,0),transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
