using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private Animator a;
    private Rigidbody2D rb;
    float x;
    public float y;
    bool canDash = true;
    bool isDashing;
    float dashingPower = 5000f;
    float dashingTime=0.2f;
    float dashingCooldown=1f;
    public BoxCollider2D col;
    public Player_Movement pm;
    [SerializeField] private TrailRenderer tr;
    // Start is called before the first frame update
    void Start()
    {
        x=(float)transform.localScale.x;
        rb=GetComponent<Rigidbody2D>();
        a=GetComponent<Animator>();
        a.SetBool("dash",false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isDashing)
        {
            return;
        }
        if(this.transform.position.x>9)
        {
            rb.AddForce(Vector2.left*250);
            pm.enabled=false;
        }
        else if(this.transform.position.x<-9)
        {
            rb.AddForce(Vector2.right*250);
            pm.enabled=false;
        }
        else if(this.transform.position.y<y)
        {
            rb.AddForce(Vector2.up*100);
            pm.enabled=false;
        }
        else
        {pm.enabled=true;
        if(Input.GetKeyDown(KeyCode.LeftAlt)&&canDash)
        {
            StartCoroutine(D());
            a.SetBool("dash",true);
            a.SetBool("jump",false);
            Invoke("F",0.2f);
        }}
        
    }
    private IEnumerator D()
    {
        canDash=false;
        isDashing=true;
        col.enabled=false;
        rb.AddForce(Vector2.right*dashingPower*((float)transform.localScale.x/x));
        tr.emitting=true;
        yield return new WaitForSeconds(dashingTime);
        col.enabled=true;
        tr.emitting=false;
        isDashing=false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash=true;
    }
    void F()
    {
        a.SetBool("dash",false);
    }
}
