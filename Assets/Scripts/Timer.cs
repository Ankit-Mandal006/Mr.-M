using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public AudioSource beep;
    //float currentTime;
    public float startingTime=30f;
    public string t;
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
        if(PlayerPrefs.GetFloat("ct",startingTime)<=0)
        {
            PlayerPrefs.SetFloat("a",0f);
            PlayerPrefs.SetFloat("ct",startingTime);
            if(t.Equals("Loose"))
                SceneManager.LoadScene(t);
            else
            {
                if(PlayerPrefs.GetInt("lap")>=1)
                    SceneManager.LoadScene("Win");
                else if(PlayerPrefs.GetInt("lap")==0)
                {
                    PlayerPrefs.SetInt("lap",1);
                    SceneManager.LoadScene(PlayerPrefs.GetString("map"));
                }
            }
        }
    }

    void B()
    {
        beep.Play();
        Invoke("B",1f);
    }
}
