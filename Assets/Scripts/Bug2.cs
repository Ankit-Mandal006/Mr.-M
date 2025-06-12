using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug2 : MonoBehaviour
{
    public float speed;
    public GameObject[] pt;
    public int rand;
    public CircleCollider2D[] col;

    public float s;
    public float ang;
    private Animator a;
    public AudioSource die;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    { 
        col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            col[4].enabled = false;
            col[5].enabled = false;
        rb=GetComponent<Rigidbody2D>();
        a=GetComponent<Animator>();
        rand=12;
        if(this.transform.position.y>50)
            s=0f;
        else
            s=speed;
        //die=GetComponent<AudioSource>();
        if(s>0f)
            Invoke("destroy",15f);
        Invoke("direction",1.75f);
    }
    void direction()
    {
        rand=Random.Range(0,pt.Length-1);
    }
    void destroy()
    {
        if(s!=0f)
            Destroy(this.gameObject);
    }
    void Instantdestroy()
    {
            Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if(s>0)
        {
            Vector2 direction=pt[rand].transform.position-transform.position;
            direction.Normalize();
            float angle=Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
            transform.position=Vector2.MoveTowards(this.transform.position,pt[rand].transform.position,s*Time.deltaTime);
            transform.rotation=Quaternion.Euler(Vector3.forward*(angle+ang));
        }
        if(this.transform.position.y<3&&this.transform.position.y>-3.6&&this.transform.position.x>-7.8&&this.transform.position.x<8)
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            col[4].enabled = true;
            col[5].enabled = true;

        }
        else
        {
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            col[4].enabled = false;
            col[5].enabled = false;
        }
        /**if(this.transform.position.y<=6&&this.transform.position.y>=3.5)
            col.enabled = false;
        else if(this.transform.position.y>6||this.transform.position.y<3.5)
            col.enabled = true;
        if(this.transform.position.y<=-4&&this.transform.position.y>=-6.5)
            col.enabled = false;
        else if(this.transform.position.y>-4||this.transform.position.y<-6.5)
            col.enabled = true;
        if(this.transform.position.x<=10&&this.transform.position.x>=7.7)
            col.enabled = false;
        else if(this.transform.position.x>10||this.transform.position.x<7.7)
            col.enabled = false;
        if(this.transform.position.x<=-8&&this.transform.position.x>=-10)
            col.enabled = false;
        else if(this.transform.position.x>-8||this.transform.position.x<-10)
            col.enabled = true;**/

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
	    if(other.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
        if(other.gameObject.CompareTag("spike"))
        {
            col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            col[4].enabled = true;
            col[5].enabled = true;

            s=0f;
        }
        if(other.gameObject.CompareTag("Player")||other.gameObject.CompareTag("Bot"))
        {
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            col[4].enabled = false;
            col[5].enabled = false;
            s=-10f;
            die.Play();
            GameObject bug=this.gameObject;
            this.transform.position=bug.transform.position;
            rb.constraints=RigidbodyConstraints2D.FreezeAll;
            //transform.position=Vector2.MoveTowards(this.transform.position,this.transform.position,s*Time.deltaTime);
           // string d="D"+(Random.Range(1,3));
           // a.SetBool(d,true);
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            col[4].enabled = false;
            col[5].enabled = false;
            Destroy(this.gameObject);
        }

        
        //if(other.gameObject.CompareTag("Pipe")&&other.gameObject.CompareTag("SmashArea"))
        //{
            //col.enabled = false;
            //Invoke("enablecolloder",3f);
        //}
        if(other.gameObject.CompareTag("Pipe"))
        {
            col[0].enabled = false;
            col[1].enabled = false;
            col[2].enabled = false;
            col[3].enabled = false;
            col[4].enabled = false;
            col[5].enabled = false;
            //Invoke("enablecolloder",3f);
        }
        if(other.gameObject.CompareTag("SA"))
        {
            col[0].enabled = col[0].enabled;
            col[1].enabled = col[1].enabled;
            col[2].enabled = col[2].enabled;
            col[3].enabled = col[3].enabled;
            col[4].enabled = col[4].enabled;
            col[5].enabled = col[5].enabled;
        }
    }

    void enablecolloder()
    {col[0].enabled = true;
            col[1].enabled = true;
            col[2].enabled = true;
            col[3].enabled = true;
            col[4].enabled = true;
            col[5].enabled = true;}
}
