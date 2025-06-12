using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Option_Menu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame


    public void option()
    {
        pauseMenu.SetActive(true);
    }

    public void back()
    {
        pauseMenu.SetActive(false);
    }
}
