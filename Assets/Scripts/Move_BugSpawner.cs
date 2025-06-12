using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_BugSpawner : MonoBehaviour
{
    public float a,speed;
    //public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        a=1f;
    }

    // Update is called once per frame
    void Update()
    {
        speed=Random.Range(1.1f,5.5f);;
        if(this.transform.position.x<-9.5f||this.transform.position.x>=9.5f)
            a=a*(-1f);
        transform.Translate(Vector2.left*a*speed*Time.deltaTime);
    }
}
