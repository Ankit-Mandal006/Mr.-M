using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public Text uid,pass,msg;
    string a,b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a=uid.text;
        b=pass.text;
    }

    public void enter()
    {
        if((uid.text).Equals("d3V")&& (pass.text).Equals("dev#2023zxcvbnm"))
            SceneManager.LoadScene("MainMenu");
        else
            msg.text="INVALID Password";
    }
}
