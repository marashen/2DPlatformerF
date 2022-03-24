using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        if (GameObject.Find("StartMusic") == true || GameObject.Find("StartMusic") != null)
        {
            GameObject.Find("StartMusic").SetActive(false);
        } 
        SceneManager.LoadScene(2);
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicMenus>().StopMusic();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void EndGame()
    {
        SceneManager.LoadScene(1);
    }
}