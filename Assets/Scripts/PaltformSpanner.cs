using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaltformSpanner : MonoBehaviour
{ 
    public GameObject[] platform;
    public GameObject[] bee;
    public GameObject[] st_pt;
    public GameObject crown;
    public float r1,a,b,SpawnLimit;
    int r2,badg;
    public Timer time;
    // Start is called before the first frame update
    void Awake()
    {
        //time=GetComponent<Timer>();
        badg=PlayerPrefs.GetInt("Badge",0);
        a=-3f;b=100f;
        r1=-4.5f;
        if(badg>=0&&badg<=5)
            SpawnLimit=5;
        else if(badg>=6&&badg<=10)
            SpawnLimit=10;
        else if(badg>=11&&badg<=15)
            SpawnLimit=15;
        else if(badg>=16&&badg<=20)
            SpawnLimit=15;
        else if(badg>=21&&badg<=25)
            SpawnLimit=20;
        else if(badg>=26&&badg<=30)
            SpawnLimit=25;
        else if(badg>=31&&badg<=35)
            SpawnLimit=25;
        else if(badg>=36&&badg<=40)
            SpawnLimit=25;
        else if(badg>=41&&badg<=45)
            SpawnLimit=30;
        else if(badg>=46&&badg<=50)
            SpawnLimit=35;
        else if(badg>=51&&badg<=55)
            SpawnLimit=35;
        else if(badg>=56&&badg<=60)
            SpawnLimit=35;
        else if(badg>=61&&badg<=65)
            SpawnLimit=35;
        else if(badg>=66&&badg<=70)
            SpawnLimit=35;
        else
            SpawnLimit=40;
        for(int i=0;i<=SpawnLimit;i++)
        {
            r1=Random.Range(r1+3f,r1+4.5f);
            r2=Random.Range(-7,7);
            Vector3 coodinates=new Vector3((float)r2,r1,0);
            Instantiate(platform[Random.Range(0,platform.Length)],(coodinates),transform.rotation);
            if(i==10)
            {
                bee[0].transform.position=new Vector3((float)0f,r1+.75f,0);
                st_pt[0].transform.position=new Vector3((float)0f,r1+.75f,0);
            }
            if(i==20)
            {
                bee[1].transform.position=new Vector3((float)0f-3f,r1+.75f,0);
                bee[2].transform.position=new Vector3((float)0f,r1+.75f,0);
                st_pt[1].transform.position=new Vector3((float)0f-3f,r1+.75f,0);
                st_pt[2].transform.position=new Vector3((float)0f,r1+.75f,0);
            }
            if(i==30)
            {
                bee[4].transform.position=new Vector3((float)0f-3.5f,r1+.75f,0);
                bee[3].transform.position=new Vector3((float)0f,r1+.75f,0);
                bee[5].transform.position=new Vector3((float)0f+3.5f,r1+.75f,0);
                st_pt[4].transform.position=new Vector3((float)0f-3.5f,r1+.75f,0);
                st_pt[3].transform.position=new Vector3((float)0f,r1+.75f,0);
                st_pt[5].transform.position=new Vector3((float)0f+3.5f,r1+.75f,0);
            }
            if(i==SpawnLimit)
            {
                Instantiate(platform[Random.Range(0,platform.Length)],(new Vector3((float)0f,r1+3.5f,(float)0f)),transform.rotation);
                crown.transform.position=new Vector3(0f,r1+5f,0f);
            }
        }
        if(badg>=0&&badg<=5)
        {
            time.startingTime=60f;
            Destroy(bee[0].gameObject);
            Destroy(st_pt[0].gameObject);
            Destroy(bee[1].gameObject);
            Destroy(st_pt[1].gameObject);
            Destroy(bee[2].gameObject);
            Destroy(st_pt[2].gameObject);
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=6&&badg<=10)
        {
            time.startingTime=60f;
            Destroy(bee[0].gameObject);
            Destroy(st_pt[0].gameObject);
            Destroy(bee[1].gameObject);
            Destroy(st_pt[1].gameObject);
            Destroy(bee[2].gameObject);
            Destroy(st_pt[2].gameObject);
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=11&&badg<=15)
        {
            time.startingTime=90f;
            Destroy(bee[1].gameObject);
            Destroy(st_pt[1].gameObject);
            Destroy(bee[2].gameObject);
            Destroy(st_pt[2].gameObject);
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=16&&badg<=20)
        {
            time.startingTime=75f;
            Destroy(bee[1].gameObject);
            Destroy(st_pt[1].gameObject);
            Destroy(bee[2].gameObject);
            Destroy(st_pt[2].gameObject);
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=21&&badg<=25)
        {
            time.startingTime=75f;
            Destroy(bee[1].gameObject);
            Destroy(st_pt[1].gameObject);
            Destroy(bee[2].gameObject);
            Destroy(st_pt[2].gameObject);
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=26&&badg<=30)
        {
            time.startingTime=60f;
            Destroy(bee[1].gameObject);
            Destroy(st_pt[1].gameObject);
            Destroy(bee[2].gameObject);
            Destroy(st_pt[2].gameObject);
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=31&&badg<=35)
        {
            time.startingTime=90f;
            Destroy(bee[2].gameObject);
            Destroy(st_pt[2].gameObject);
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=36&&badg<=40)
        {
            time.startingTime=105f;
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=41&&badg<=45)
        {
            time.startingTime=90f;
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=46&&badg<=50)
        {
            time.startingTime=80f;
            Destroy(bee[3].gameObject);
            Destroy(st_pt[3].gameObject);
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=51&&badg<=55)
        {
            time.startingTime=120f;
            Destroy(bee[4].gameObject);
            Destroy(st_pt[4].gameObject);
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=56&&badg<=60)
        {
            time.startingTime=120f;
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=61&&badg<=65)
        {
            time.startingTime=105f;
            Destroy(bee[5].gameObject);
            Destroy(st_pt[5].gameObject);
        }
        else if(badg>=66&&badg<=70)
        {
            time.startingTime=100f;
        }
        else
        {
            time.startingTime=90f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
