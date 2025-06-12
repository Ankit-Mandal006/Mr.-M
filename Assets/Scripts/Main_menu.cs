using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    string a;
    public Text b,s;
    public Image i1,i2,i3;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("Badge",0);
        //PlayerPrefs.SetInt("Star",0);
        //PlayerPrefs.SetInt("p",0);
        //PlayerPrefs.SetInt("md",0);
        //PlayerPrefs.SetInt("bs",0);
        //PlayerPrefs.SetInt("sr",0);
        PlayerPrefs.SetInt("Bge",1);
        PlayerPrefs.SetInt("lap",0);
        string[] a1={"P","Bug_Smash","Magma Douge","Sand Run"};
        a=a1[Random.Range(0,a1.Length)];
        PlayerPrefs.SetString("map",a1[Random.Range(0,a1.Length)]);
        while(a.Equals(PlayerPrefs.GetString("map",a1[Random.Range(0,a1.Length)])))
            PlayerPrefs.SetString("map",a1[Random.Range(0,a1.Length)]);
    }

    // Update is called once per frame
    void Update()
    {
       Time.timeScale=1f; 
        b.text="+ "+PlayerPrefs.GetInt("Badge");
        s.text="+ "+PlayerPrefs.GetInt("Star");
        if(PlayerPrefs.GetInt("Star")>=10000)
            i1.enabled=false;
        if(PlayerPrefs.GetInt("Badge")>=50)
            i2.enabled=false;
        if(PlayerPrefs.GetInt("p",0)==1&&PlayerPrefs.GetInt("md",0)==1&&PlayerPrefs.GetInt("bs",0)==1&&PlayerPrefs.GetInt("sr",0)==1)
            i3.enabled=false;
    }
    public void play()
    {
        SceneManager.LoadScene(a);
        Time.timeScale=1f;
    }
    public void DropDown(int n)
    {
        if(n==0)
        {
            PlayerPrefs.SetInt("Bge",1);
            PlayerPrefs.SetInt("lap",0);
            string[] a1={"P","Bug_Smash","Magma Douge","Sand Run"};
            a=a1[Random.Range(0,a1.Length)];
            PlayerPrefs.SetString("map",a1[Random.Range(0,a1.Length)]);
            while(a.Equals(PlayerPrefs.GetString("map",a1[Random.Range(0,a1.Length)])))
                PlayerPrefs.SetString("map",a1[Random.Range(0,a1.Length)]);
        }
        if(n==1)
        {
            PlayerPrefs.SetInt("Bge",0);
            PlayerPrefs.SetInt("lap",1);
            a="P";
        }
        
        if(n==2)
        {
            PlayerPrefs.SetInt("Bge",0);
            PlayerPrefs.SetInt("lap",1);
            a="Bug_Smash";
        }
        if(n==3)
        {
            PlayerPrefs.SetInt("Bge",0);
            PlayerPrefs.SetInt("lap",1);
            a="Magma Douge";
        }
        if(n==4)
        {
            PlayerPrefs.SetInt("Bge",0);
            PlayerPrefs.SetInt("lap",1);
            a="Sand Run";
        }

    }
    public void exit()
    {
        Application.Quit();
    }
    
}
