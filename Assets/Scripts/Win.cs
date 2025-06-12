using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public Text badge;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Bge")==1)
        {
            PlayerPrefs.SetInt("Badge", PlayerPrefs.GetInt("Badge",0)+1);
            PlayerPrefs.SetInt("Star",(int)(PlayerPrefs.GetInt("Star",0)+10+(int)((100)*(1+PlayerPrefs.GetInt("Badge",0)/100))));
        }
        else if(PlayerPrefs.GetInt("Bge")==0)
        {
            PlayerPrefs.SetInt("Star",(int)(PlayerPrefs.GetInt("Star",0)+10+(int)((1000)*(PlayerPrefs.GetInt("Badge",0)/100))));
        }
        badge.text=PlayerPrefs.GetInt("Badge")+"";
        Score.text=PlayerPrefs.GetInt("Star")+"";
        
    }

    // Update is called once per frame
    void Update()
    { //PlayerPrefs.SetInt("Star",0);PlayerPrefs.SetInt("Badge",0);
    }
}
