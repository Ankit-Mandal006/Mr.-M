using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{
    public GameObject[] thunder;
    public GameObject[] spawn;
    public AudioSource tud;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("thud",Random.Range(3f,8f));
    }
    void thud()
    {
        int rn=Random.Range(0,2);
        
        if(rn==0)
        {
           GameObject g= Instantiate((thunder[Random.Range(2,4)]),spawn[rn].transform.position,spawn[rn].transform.rotation);
        }
        else
        {
            Instantiate((thunder[Random.Range(0,2)]),spawn[rn].transform.position,spawn[rn].transform.rotation);
        }
        tud.Play();
        Invoke("thud",Random.Range(8f,10f));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
