using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magma : MonoBehaviour
{
     public GameObject[] sp;
    public GameObject[] magma1;
    public GameObject[] magma2;
    public GameObject death,boom;
    public float Speed;
    public int a,dest;
    public string method;
    public AudioSource blast;
    
    void Start()
    {
        dest=1;
        Speed=Random.Range(10f,15f);
        float r=Random.Range(0.4f,0.7f);
        this.transform.localScale=new Vector2(r,r);
        boom.transform.rotation=Quaternion.Euler(Vector3.forward*(Random.Range(0,360)));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector2.MoveTowards(this.transform.position,death.transform.position,Speed*Time.deltaTime);
        if(transform.position.y<-61f)
        {
            Destroy(this.gameObject);
            Magmagen0();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("g"))
        {
            Destroy(this.gameObject);
            Magmagen0();
        }
        if(other.gameObject.CompareTag("spike"))
        {
           dest=0;
        }
        if(other.gameObject.CompareTag("magma")&&dest!=0f)
        {
           Destroy(this.gameObject);
           Instantiate(boom,this.transform.position,this.transform.rotation);
           blast.Play();
           method="Magmagen"+(Random.Range(0,2)).ToString();
            Invoke(method,0.1f);
        }
    }
    public void Magmagen0()
    {
        int s=Random.Range(0,2);
        if(s==0)
            Instantiate(magma1[Random.Range(0,magma1.Length)],sp[s].transform.position,this.transform.rotation);
        else
            Instantiate(magma2[Random.Range(0,magma2.Length)],sp[s].transform.position,this.transform.rotation);
        
    }
    public void Magmagen1()
    {}
}
