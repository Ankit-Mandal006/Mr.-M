using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    public float speed;
    public GameObject[] pt;
    public int rand;
    public EdgeCollider2D col;
    public GameObject c;
    public float s;
    public float ang;
    private Animator a;
    public AudioSource die;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    { 
        rb=GetComponent<Rigidbody2D>();
        a=GetComponent<Animator>();
        rand=Random.Range(0,pt.Length);
        col=c.GetComponent<EdgeCollider2D>();
        //die=GetComponent<AudioSource>();
        s=speed;
        Invoke("destroy",15f);
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
            col.enabled = true;
            s=0f;
        }
        if(other.gameObject.CompareTag("Player")||other.gameObject.CompareTag("Bot"))
        {
            col.enabled = false;
            s=-10f;
            die.Play();
            GameObject bug=this.gameObject;
            this.transform.position=bug.transform.position;
            rb.constraints=RigidbodyConstraints2D.FreezeAll;
            //transform.position=Vector2.MoveTowards(this.transform.position,this.transform.position,s*Time.deltaTime);
            string d="D"+(Random.Range(1,3));
            a.SetBool(d,true);
            col.enabled = false;
            Invoke("Instantdestroy",1f);
        }

        
        //if(other.gameObject.CompareTag("Pipe")&&other.gameObject.CompareTag("SmashArea"))
        //{
            //col.enabled = false;
            //Invoke("enablecolloder",3f);
        //}
        if(other.gameObject.CompareTag("Pipe"))
        {
            col.enabled = false;
            //Invoke("enablecolloder",3f);
        }
        if(other.gameObject.CompareTag("SA"))
        {
            col.enabled = !col.enabled;
        }
    }

    void enablecolloder()
    {col.enabled = true;}
}
