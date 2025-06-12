using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Movement : MonoBehaviour
{
   public float speed;
   private float Move;
   public float jump;
   public bool isJumping;
   AudioSource jumpsound;
   private Rigidbody2D rb;
   private Animator a;
   int j;
   void Start()
   {
       rb=GetComponent<Rigidbody2D>();
       a=GetComponent<Animator>();
       jumpsound=GetComponent<AudioSource>();
       Move=1f;
       j=1;
   }
   void jmp()
   {
       j=1;
   }
   void Update()
   {
       Move=Input.GetAxis("Horizontal");
       rb.velocity=new Vector2(speed*Move,rb.velocity.y);
       if(Move>0)
       {
        a.SetBool("run",true);
        gameObject.transform.localScale=new Vector3(0.43778f,0.43778f,transform.localScale.z);
       }
       else if(Move<0)
       {
        a.SetBool("run",true);
        gameObject.transform.localScale=new Vector3(-0.43778f,0.43778f,transform.localScale.z);    
       }
       else if(Move==0)
       {
        a.SetBool("run",false);
        a.SetBool("ideal",true);
       }
       if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.Space))
	    {
		    if(isJumping==true&&j==1)
		    { 
                jumpsound.Play();
                a.SetBool("run",false);
			    rb.AddForce(Vector2.up*jump);
                a.SetBool("jump",true);
			    isJumping=false;
                j=0;
                Invoke("jmp",0.5f);
		    }
        }
        if(Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow))
        {   
            if(isJumping==false)
            {
            a.SetBool("run",false);
            a.SetBool("jump",true);
            rb.AddForce(Vector2.down*jump);
            }
        }
        a.SetFloat("yVelocity",rb.velocity.y);
   }
   private void OnCollisionEnter2D(Collision2D collision)
   {
    if(collision.gameObject.CompareTag("ground"))
	{
		if(isJumping==false)
		{
			isJumping=true;
		}
	}
    a.SetBool("jump",!isJumping);
        if(collision.gameObject.CompareTag("Mouse"))
        {
            Vector2 knockback=(this.transform.position-collision.gameObject.transform.position).normalized;
            ApplyKnockback(knockback);
        }
   }

   private void ApplyKnockback(Vector2 knockback)
   {
       rb.velocity=Vector2.zero;
       rb.AddForce(knockback*1000f,ForceMode2D.Impulse);
   }
}
