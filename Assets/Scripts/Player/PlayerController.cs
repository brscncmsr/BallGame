using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //It is unity event for trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //It is detect if player hit the enemy
        if (collision.CompareTag("Enemy"))//It compares tag and if it "Enemy" it returns true
        {
            //Call FailGame Func
            LevelManager.Instance.FailGame();

        }
    }
}
