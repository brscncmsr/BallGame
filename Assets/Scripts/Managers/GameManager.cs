using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//It is game manager it provides start,restart,and menu funcs
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;//makes static to easily acces
    //Get Gameobject to open and close
    public GameObject Options;
    public GameObject MainMenü;
    public GameObject Name;
    private void Awake()
    {
        Instance = this;//to make static
        Time.timeScale = 1f;//Stop Freeze
    }
    public void StartGame()
    {
        //Load Game Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        //Close the Game
        Application.Quit();
    }
    public void RestartGame()
    {
        //Reload the Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void AgainGame()
    {
        //Go to menu
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    public void OptionsPanel()
    {
        //Open Option Paneþ
        Options.SetActive(true);
        MainMenü.SetActive(false);
    }
    public void GetBackMenu()
    {
        //Open MENU
        Options.SetActive(false);
        MainMenü.SetActive(true);
    }
    public void PlayMenu()
    {
        //Start Game
        MainMenü.SetActive(false);
        Name.SetActive(true);
    }
}
