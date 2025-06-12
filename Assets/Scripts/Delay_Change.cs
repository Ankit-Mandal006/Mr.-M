using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Delay_Change : MonoBehaviour
{
    public string s;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("MM",3f);
    }
    void MM()
    {
        SceneManager.LoadScene(s);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
