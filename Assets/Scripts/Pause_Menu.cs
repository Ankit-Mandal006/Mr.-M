using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale=1f;
        pauseMenu.SetActive(false);
        Cursor.visible=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!pauseMenu.activeSelf)
            {
                PlayerPrefs.SetFloat("a",0f);
                Time.timeScale=0f;
                pauseMenu.SetActive(true);
                Cursor.visible=true;
            }
            else
            {
                PlayerPrefs.SetFloat("a",1f);
                Time.timeScale=1f;
                pauseMenu.SetActive(false);
                Cursor.visible=false;
            }
        }
    }

    public void quit()
    {
        PlayerPrefs.SetFloat("a",0f);
        SceneManager.LoadScene("MainMenu");
        //Application.Quit();
    }

    public void resume()
    {
        PlayerPrefs.SetFloat("a",1f);
        Time.timeScale=1f;
        pauseMenu.SetActive(false);
        Cursor.visible=false;
    }
}
