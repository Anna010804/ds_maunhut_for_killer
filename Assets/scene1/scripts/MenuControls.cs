using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControls : MonoBehaviour
{

    public GameObject menu;    
    public GameObject settings;    

    public void Start() 
{
        Debug.Log("START!");
        if (settings!=null) settings.SetActive(false);
}
 
    public void PlayPressed()
    {
        SceneManager.LoadScene("Scenes/game");
    }

    public void SettingsPressed() 
    {
        Debug.Log("Settings pressed!");
        if (menu!=null) menu.SetActive(false);
        if (settings!=null) settings.SetActive(true);
    }

    public void ExitPressed()
    {
        Debug.Log("Exit pressed!");
        Application.Quit();
    }
}
