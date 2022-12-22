using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//It for the manage the Levels
public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    public GameObject playerModel;
    public GameObject enemyModel;
    //Scriptable Object
    public UserOptions userData;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        //It assign the model and color to player and enemy
        SpriteRenderer a=playerModel.GetComponent<SpriteRenderer>();
        a.sprite = userData.playerModel;
        a.color = userData.playerColor;
        enemyModel.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = userData.playerModel;
    }

    //When the time finish the func will run
    public void FinishGame()
    {
        //Get UýManager elements
        UIManager.Instance.succes.text = "Congratulations : " + userData.userName;
        UIManager.Instance.finish.SetActive(true);
        Time.timeScale = 0f;//Freeze Time
    }
    //When the player fail the func will run
    public void FailGame()
    {
        UIManager.Instance.fail.SetActive(true);
        Time.timeScale = 0f;//Freeze
    }
}
