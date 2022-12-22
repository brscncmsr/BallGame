using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "User", menuName = "ScriptableObjects/UserOptions", order = 1)]
//This scriptable object use for save data in game
public class UserOptions : ScriptableObject
{
    public Sprite playerModel;//Save Player Data
    public Color playerColor;//Save player Color
    public string userName;//Save PLayer name
   
}
