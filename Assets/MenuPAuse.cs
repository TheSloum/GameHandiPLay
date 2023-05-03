using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPAuse : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenueUI;
    

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }

        void Paused()
        {
           
            pauseMenueUI.SetActive(true);
            Time.timeScale = 0;
            gameIsPaused = true;
        }

        

        
    }

    void Resume()
    {

        pauseMenueUI.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }

    public void LoadCreditScene()
    {
        SceneManager.LoadScene(2);
        Resume();

    }

    public void QuitGame()
    {
        Application.Quit();

    }

}
