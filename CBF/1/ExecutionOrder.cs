using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionOrder : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    private void Update()
    {
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Debug.Log("OnDrawGizmo");
    }
#endif

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
}
