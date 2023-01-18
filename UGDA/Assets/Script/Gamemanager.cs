using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance { get; private set; }
    public GameObject Option;
    public GameObject LoadSave;
    public GameObject Tutorial;
    public void OptionMenu()
    {
        //Will open Option Menu and pause game
        Option.SetActive(true);
        LoadSave.SetActive(false);
        Tutorial.SetActive(false);
        Time.timeScale = 0;
    }
    public void SaveLoadMenu()
    {
        //Will open SaveLoad Menu and pause game         
        LoadSave.SetActive(true);
        Option.SetActive(false);
        Tutorial.SetActive(false);
        Time.timeScale = 0;
    }

    public void BackButton()
    {
        //Will go back to game and all Menus
        LoadSave.SetActive(false);
        Option.SetActive(false);
        Time.timeScale = 1;
    }

    public void TutorilPanel()
    {
        Tutorial.SetActive(true);
    }

    public void QuitButton()
    {
        //Will quit the game
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
