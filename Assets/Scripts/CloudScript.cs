using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    //public GameObject cld;
    float Speed;
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        Speed=Random.Range(1.1f,2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position.x<18f&&transform.position.x>19)||(transform.position.x>-18f&&transform.position.x<-19f))
            Invoke("destroy",10f);
        transform.Translate(Vector2.left*a*Speed*Time.deltaTime);
    }

    void destroy()
    {
        Destroy(this.gameObject);
    }
}
