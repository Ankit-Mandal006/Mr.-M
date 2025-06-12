using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public Rigidbody2D rb;
    public Player_Movement pm;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            pm.enabled=false;
            if(this.transform.position.x>=player.transform.position.x)
                rb.AddForce(Vector2.right*200);
            if(this.transform.position.x<player.transform.position.x)
                rb.AddForce(Vector2.left*200);
            Invoke("ply_Mo",0.2f);
        }
    }

    void ply_Mo()
   {
       pm.enabled=true;
   }
}
