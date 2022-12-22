using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20f;
    public float speed2 = 20f;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = Random.Range(0, 10);
        speed2 = Random.Range(0, 10);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (transform.up * speed) + (transform.right * speed2);
    }
}
