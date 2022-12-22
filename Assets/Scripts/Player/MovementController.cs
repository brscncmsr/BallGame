using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float moveSpeed = 10f;

    Vector2 lastClick;

    bool isMove;
    private void Update()
    {
        //if mouse left click
        if (Input.GetMouseButtonDown(0))
        {
            //get screen point the last touched point
            lastClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMove = true;
        }
        if (isMove && (Vector2)transform.position != lastClick)
        {
            // it provides the object go to click point smoothly
            float step = moveSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClick, step);
        }
        else
        {
            isMove = false;
        }
    }

}
