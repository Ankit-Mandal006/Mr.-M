using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rand_tree : MonoBehaviour
{
    private Animator a;
    // Start is called before the first frame update
    void Start()
    {
       a=GetComponent<Animator>();
       var state=a.GetCurrentAnimatorStateInfo(0); 
       a.Play(state.fullPathHash,0,Random.Range(0f,1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
