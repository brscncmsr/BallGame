using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the enemy hits that trigger it close it to reborn
        collision.gameObject.SetActive(false);
    }
}
