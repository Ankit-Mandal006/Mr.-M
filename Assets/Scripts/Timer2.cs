using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{
    AudioSource beep;
    //float currentTime;
    public float startingTime;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        beep=GetComponent<AudioSource>();
        PlayerPrefs.SetFloat("a",1f);
        PlayerPrefs.SetFloat("ct",startingTime);
        Invoke("B",(startingTime-5));
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("ct",PlayerPrefs.GetFloat("ct",startingTime)-PlayerPrefs.GetFloat("a",1f)*Time.deltaTime);
        TimeSpan time =TimeSpan.FromSeconds(PlayerPrefs.GetFloat("ct",startingTime));
        countdownText.text=time.Minutes.ToString()+" : "+time.Seconds.ToString();
        if(PlayerPrefs.GetFloat("ct")<=0)
         {
             if(PlayerPrefs.GetInt("Point1",0)>PlayerPrefs.GetInt("Point2",0))
             {
                PlayerPrefs.SetFloat("a",0f);
                if(PlayerPrefs.GetInt("lap")>=1)
                    SceneManager.LoadScene("Win");
                else if(PlayerPrefs.GetInt("lap")==0)
                {
                    PlayerPrefs.SetInt("lap",1);
                    SceneManager.LoadScene(PlayerPrefs.GetString("map"));
                }
             }
            else    
                SceneManager.LoadScene("Loose");
         }
    }
    
    void B()
    {
        beep.Play();
        Invoke("B",1f);
    }
}
