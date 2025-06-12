using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Movement2 : MonoBehaviour
{
    public float Movex;
    public float Movey;
    private Rigidbody2D rb;
    private Animator a;
    public float speed;
    public Text p1;
    public Text p2;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Point1",00);
        rb=GetComponent<Rigidbody2D>();
        a=GetComponent<Animator>();
    }
    void LateUpdate()
    {
       if(Movex==0&&Movey==0)
            a.SetBool("walk",false);
    }
    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("a",1f);
        if(Movex==0&&Movey==0)
            a.SetBool("walk",false);
        
        Movey=Input.GetAxis("Vertical");
        rb.velocity=new Vector2(speed*Movey,rb.velocity.y);
        Movex=Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(speed*Movex,rb.velocity.x);
        if(Movex>0&&Movey>0)
            this.transform.rotation=Quaternion.Euler(Vector3.forward*45);
        else if(Movex>0&&Movey<0)
            this.transform.rotation=Quaternion.Euler(Vector3.forward*-45);
        else if(Movex<0&&Movey>0)
            this.transform.rotation=Quaternion.Euler(Vector3.forward*135);
        else if(Movex<0&&Movey<0)
            this.transform.rotation=Quaternion.Euler(Vector3.forward*-135);
        else if(Movex>0)
            this.transform.rotation=Quaternion.Euler(Vector3.forward*0);
        else if(Movex<0)
            this.transform.rotation=Quaternion.Euler(Vector3.forward*180);
        else if(Movey>0)
            this.transform.rotation=Quaternion.Euler(Vector3.forward*90);
        else if(Movey<0)
            this.transform.rotation=Quaternion.Euler(Vector3.forward*-90);
        if(Movex!=0||Movey!=0)
            a.SetBool("walk",true);   
        else 
            a.SetBool("walk",false);

        if(Movex==0&&Movey==0)
            a.SetBool("walk",false);

        p1.text=(PlayerPrefs.GetInt("Point1",00)).ToString()+"";
        p2.text=(PlayerPrefs.GetInt("Point2",00)).ToString()+"";
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Cocroach"))
        {
            PlayerPrefs.SetInt("Point1",(PlayerPrefs.GetInt("Point1",0)+1));
        }
        if(other.gameObject.CompareTag("Mouse"))
        {
            PlayerPrefs.SetInt("Point1",(PlayerPrefs.GetInt("Point1",0)+5));
        }
    }
}