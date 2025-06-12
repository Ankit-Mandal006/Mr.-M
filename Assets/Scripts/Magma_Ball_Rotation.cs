using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magma_Ball_Rotation : MonoBehaviour
{
    public CircleCollider2D col;
    public float a,b;
    // Start is called before the first frame update
    void Awake()
    {
        col=this.GetComponent<CircleCollider2D>();
        b=1.5f;
        rot();
        col.enabled = true;
    }

    void rot()
    {
        b+=1.5f;
        transform.rotation=Quaternion.Euler(Vector3.forward*(b*a));
        Invoke("rot",0.005f);
    }
    // Update is called once per frame
    void Update()
    {
        col.enabled = true;
    }
}
