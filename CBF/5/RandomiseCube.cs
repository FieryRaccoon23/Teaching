using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseCube : MonoBehaviour
{
    private Pooling m_Pooling;

    private float m_Speed = 5.0f;

    private float m_End = -10.0f;

    private void Update()
    {
        if (transform.position.y > m_End)
        {
            transform.Translate(Vector3.down * Time.deltaTime * m_Speed, Space.World);
        }
        else
        {
            m_Pooling.Pool.Release(gameObject);
        }
    }

    private void OnEnable()
    {
        //transform.position = new Vector3(0.0f, 10.0f, 0.0f);
        transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 10.0f, 0.0f);
    }

    private void OnDisable()
    {
        
    }

    private void Start()
    {
        GameObject poolingGameObject = GameObject.FindGameObjectWithTag("pool");
        m_Pooling = poolingGameObject.GetComponent<Pooling>();
    }

}
