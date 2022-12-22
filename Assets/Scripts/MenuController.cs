using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
//It is for the menu func and save the data to ScriptableObject
public class MenuController : MonoBehaviour
{
    public UserOptions user;
    public TextMeshProUGUI text;
    public void SetData()
    {
        //Set the data to scriptableObject model and color data
        GameObject tmp = EventSystem.current.currentSelectedGameObject;
        user.playerColor = tmp.GetComponent<Image>().color;
        user.playerModel = tmp.GetComponent<Image>().sprite;

    }
    public void SetName()
    {
        //set name to scrþiptableobject
        user.userName = text.text;
        GameManager.Instance.StartGame();
    }



}
