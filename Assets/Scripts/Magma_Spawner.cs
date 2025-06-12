using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagmaChain_Spawner : MonoBehaviour
{
    public GameObject[] sp;
    public GameObject[] magma;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Magma",0.5f);
    }
    public void Magma()
    {
        int randEnemy=Random.Range(0,magma.Length);
        float r=Random.Range(3f,4f);
        Instantiate(magma[randEnemy],sp[Random.Range(0,3)].transform.position,this.transform.rotation);
        Invoke("Magma",r);
    }
}