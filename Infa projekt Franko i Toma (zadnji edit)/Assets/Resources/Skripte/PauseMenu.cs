using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //deklariramo bool koji provjerava jeli igra pauzirana i gameobject kako bi preko unitya mogli povezati dizajn i komponente PauseMenua
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    void Update()
    {
        //konstantno provjerava jesmo li stisli escape tipku te poziva odgovarajucu funkciju
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            Resume();
            else
            {
                Pause();
            }
        }
        
    }
    public void Resume()
    {
        //mijenja bool kako bi znali kako mijenjati PauseMenu te stavlja time scale na 1 kako bi vrijeme nesmetano islo te kako bi igra radila
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        //mijenja bool kako bi znali kako mijenjati PauseMenu te stavlja time scale na 0 kako vrijeme nebi teklo
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        //vraca nas na MainMenu
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        //izlaz iz aplikacije
        Application.Quit();
    }
}
