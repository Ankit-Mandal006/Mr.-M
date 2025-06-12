using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public GameObject[] cloud;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawnCloud",Random.Range(3f,6f));
    }

    void spawnCloud()
    {
        Vector3 a=new Vector3((float)transform.position.x,Random.Range((float)transform.position.y-1,(float)transform.position.y+1),10f);
        Instantiate(cloud[Random.Range(0,cloud.Length)],a,transform.rotation);
        Invoke("spawnCloud",Random.Range(3f,6f));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
