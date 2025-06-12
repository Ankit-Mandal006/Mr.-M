using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public GameObject[] pt;
    public GameObject rpt;
    public int rand;
    public float s,x,y;
    private Animator a;
    // Start is called before the first frame update
    void Start()
    { 
        x=this.transform.position.x;
        y=this.transform.position.y;
        PlayerPrefs.SetInt("Point2",00);
        rand=Random.Range(0,pt.Length);
        a=GetComponent<Animator>();
        Invoke("ChangePath",3f);
        Invoke("CurrentPath",0.5f);
        Invoke("returnPoint",2f);
    }

    void returnPoint()
    {
        rand =26;
        Invoke("returnPoint",2f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction=pt[rand].transform.position-transform.position;
        direction.Normalize();
        float angle=Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        transform.position=Vector2.MoveTowards(this.transform.position,pt[rand].transform.position,s*Time.deltaTime);
        transform.rotation=Quaternion.Euler(Vector3.forward*angle);
        a.SetBool("walk",true);
        if(x==this.transform.position.x||y==this.transform.position.y)
           ChangePath(); 
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
	    if(other.gameObject.CompareTag("Pipe"))
        {
            rand=Random.Range(0,pt.Length);
        }
        if(other.gameObject.CompareTag("Player"))
        {
            rand=Random.Range(0,pt.Length);
        }
        if(other.gameObject.CompareTag("SA"))
        {
            rand=Random.Range(0,pt.Length);
        }
        if(other.gameObject.CompareTag("Cocroach"))
        {
            PlayerPrefs.SetInt("Point2",(PlayerPrefs.GetInt("Point2",0)+1));
        }
        if(other.gameObject.CompareTag("Mouse"))
        {
            PlayerPrefs.SetInt("Point2",(PlayerPrefs.GetInt("Point2",0)+5));
        }
    }

    void CurrentPath()
    {
        x=this.transform.position.x;
        y=this.transform.position.y;
        Invoke("CurrentPath",0.5f);
    }
    void ChangePath()
    {
        rand=Random.Range(0,pt.Length);
        Invoke("ChangePath",1.5f);
    }
}
