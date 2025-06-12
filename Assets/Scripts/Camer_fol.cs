using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer_fol : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    float a;
    // Start is called before the first frame update
    void Start()
    {
        //a=transform.position.x-player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position=new Vector3(player.transform.position.x+5f,4f,-10f);
    }
}
