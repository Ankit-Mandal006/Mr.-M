using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement3 : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump;
   public bool isJumping;
   public AudioSource jumpsound;
   private Animator a;
   
   int j;
    // Start is called before the first frame update
    void Start()
    {j=1;
        rb=GetComponent<Rigidbody2D>();
        a=GetComponent<Animator>();
    }
    void jmp()
   {
       j=1;
   }
    // Update is called once per frame
    void Update()
    {
        a.SetBool("run",true);
       // rb.AddForce(Vector2.right*10f)
       transform.Translate(Vector2.right*(10f*PlayerPrefs.GetFloat("a")*Time.deltaTime));
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
        
    }
}
