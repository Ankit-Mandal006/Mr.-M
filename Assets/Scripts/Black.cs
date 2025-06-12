using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Black : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("a",1f);
        Invoke("black",1f);
    }
    void black()
    {
        SceneManager.LoadScene("Platformer1_"+PlayerPrefs.GetInt("rn1",1).ToString());
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("Platformer1_"+PlayerPrefs.GetInt("rn1",1).ToString());
    }
}
