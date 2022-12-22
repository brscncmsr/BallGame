using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//This manager use for controll all Uý elements
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TextMeshProUGUI counter;//time text
    public TextMeshProUGUI succes;//cong text
    public TextMeshProUGUI enemy;//score text
    public GameObject finish;//finish canvas
    public GameObject fail;//fail canvas
    public float timeRemaining = 10;//gametime
    public float scoreMultiply=5;//gives that value to score per frame
    float minutes;//stylize UI munites
    float seconds;//stylize Uý Seconds
    float point = 0;//Score
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        //Divide time to minutes and seconds
        minutes = Mathf.FloorToInt(timeRemaining / 60);
        seconds = Mathf.FloorToInt(timeRemaining % 60);
    }
    void Update()
    {
        Timer();
        //Set Point
        enemy.text = "Point : " + Mathf.FloorToInt(point = point +  scoreMultiply* Time.deltaTime).ToString(); 
    }
    //It is timer function for show the time
    public void Timer()
    {
        if (timeRemaining > 0)
        {
            //the time decreases by time.deltatime
            timeRemaining -= Time.deltaTime;
            minutes = Mathf.FloorToInt(timeRemaining / 60);
            seconds = Mathf.FloorToInt(timeRemaining % 60);
            //Clamp is take the time min 0 if we dont use clamp time goes minus values
            minutes = Mathf.Clamp(minutes, 0, minutes);
            seconds = Mathf.Clamp(seconds, 0, seconds);
            //show the time
            counter.text = "Time : " + string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            //if time is done calls finish game
            LevelManager.Instance.FinishGame();
        }
    }
    
}
