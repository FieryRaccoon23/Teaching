using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Pool;

public class Pooling : MonoBehaviour
{
    [SerializeField]
    private GameObject m_ObjectBluePrint;

    private IObjectPool<GameObject> m_Pool;

    private int maxPoolSize = 5;

    public bool collectionChecks = true;

    // Property
    public IObjectPool<GameObject> Pool
    {
        get
        {
            if (m_Pool == null)
            {
                m_Pool = new LinkedPool<GameObject>(CreatePooledItem, OnTakeFromPool, OnReturnedToPool, OnDestroyPoolObject, collectionChecks, maxPoolSize);
            }
            return m_Pool;
        }
    }

    // Create/Instantiate a new game object
    GameObject CreatePooledItem()
    {
        GameObject obj = Instantiate(m_ObjectBluePrint, Vector3.zero, Quaternion.identity);
        return gameObject;
    }

    // Called when an item is returned to the pool using Release
    void OnReturnedToPool(GameObject obj)
    {
        obj.SetActive(false);
    }

    // Called when an item is taken from the pool using Get
    void OnTakeFromPool(GameObject obj)
    {
        obj.SetActive(true);
    }

    // If the pool capacity is reached then any items returned will be destroyed.
    // We can control what the destroy behavior does, here we destroy the GameObject.
    void OnDestroyPoolObject(GameObject obj)
    {
        Destroy(obj);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pool.Get();
        }
    }
}
