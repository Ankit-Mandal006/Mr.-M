using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dest_Boom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((float)this.transform.position.y>-64)
            Invoke("dest",2f);
    }
    void dest()
    {
        Destroy(this.gameObject);
    }
}
