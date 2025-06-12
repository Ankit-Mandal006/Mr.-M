using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Destory : MonoBehaviour
{
    public GameObject x;
    public GameObject sp;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("X",3f);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("del"))
          {
           Destroy(x.gameObject);
            SceneManager.LoadScene("MainMenu");
          }
        if(other.gameObject.CompareTag("st_p"))
            transform.position=Vector2.MoveTowards(sp.transform.position,sp.transform.position,100f);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke("X",3f);
    }

    void Delay()
    {
        //Invoke("X",1f);
    }

    void X()
    {
       // transform.position=Vector2.MoveTowards(sp.transform.position,sp.transform.position,100f);
       // Start();
    }
}
