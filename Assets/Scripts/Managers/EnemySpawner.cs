using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] points;
    public float spawntime = 1f;
    public float destroyTime=3f;
    private bool islock = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!islock)
        {
            islock = true;
            StartCoroutine(ReSpawn());
        }

    }
    public int GetPoint()
    {
        return Random.Range(0, points.Length);
    }
    public void Spawn(int index)
    {
        GameObject enemy = EnemyPool.SharedInstance.GetPooledObject();
        if (enemy != null)
        {
            enemy.transform.position = points[index].position;
            enemy.transform.rotation = points[index].rotation;
            enemy.SetActive(true);
            StartCoroutine(DeSpawn(enemy));
        }
    }
    IEnumerator ReSpawn()
    {
        int index = GetPoint();
        Spawn(index);
        yield return new WaitForSeconds(spawntime);
        islock = false;
    }
    IEnumerator DeSpawn(GameObject enemy)
    {
        yield return new WaitForSeconds(destroyTime);
        enemy.SetActive(false);
    }
}
