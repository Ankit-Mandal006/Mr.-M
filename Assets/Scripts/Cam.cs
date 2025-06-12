using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{ 
    public GameObject player;
    float a;
    // Start is called before the first frame update
    void Start()
    {
        a=transform.position.y-player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position=new Vector3(0f,player.transform.position.y+a,-10f);
    }
}
