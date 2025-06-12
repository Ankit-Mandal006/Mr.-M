using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public GameObject st_pt;
    public float speed,Y,X1,X2;
    // Start is called before the first frame update
    void Start()
    {
        Y=this.transform.position.y;
        X1=this.transform.localScale.x;
        X2=-1*this.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction=player.transform.position-transform.position;
        direction.Normalize();
        if(player.transform.position.y<Y+6f&&player.transform.position.y>=Y-6f)
        {

            transform.position=Vector2.MoveTowards(this.transform.position,player.transform.position,speed*Time.deltaTime);
            if(this.transform.position.x>player.transform.position.x)
                transform.localScale=new Vector2(X2,this.transform.localScale.y);
            else
                transform.localScale=new Vector2(X1,this.transform.localScale.y);
        }
        else
        {
            transform.position=Vector2.MoveTowards(this.transform.position,st_pt.transform.position,speed*Time.deltaTime);
        }
    }

    
}