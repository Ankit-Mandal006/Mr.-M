using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        PlayerPrefs.SetFloat("a",0f);
        Time.timeScale=0f;
        //PlayerPrefs.SetFloat("a",0f);
        Invoke("fd",5f);
        
    }

    void fd()
    {
        PlayerPrefs.SetFloat("a",1f);
        Time.timeScale=1f;
        //PlayerPrefs.SetFloat("a",1f);
        SceneManager.LoadScene("Black");
        SceneManager.LoadScene("Platformer1_"+PlayerPrefs.GetInt("rn1",1).ToString());
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("a",0f);
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            fd();
        }
    }
}
