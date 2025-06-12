using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MODE : MonoBehaviour
{
    public string a;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt(a,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
