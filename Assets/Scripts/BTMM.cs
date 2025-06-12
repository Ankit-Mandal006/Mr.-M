using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTMM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("m",2f);
    }
    void m()
    {SceneManager.LoadScene("MainMenu");}
    // Update is called once per frame
    void Update()
    {
        
    }
}
