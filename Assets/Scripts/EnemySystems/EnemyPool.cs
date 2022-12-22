using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public static EnemyPool SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public Transform parent;
    public int amountToPool;

    private void Awake()
    {
        SharedInstance = this;
    }
    private void Start()
    {
        //it is pooling system to optimize system for make objects and destroy
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.transform.SetParent(parent);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }
    public GameObject GetPooledObject()
    {
        //Check objects are active or passive
        for (int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

}
