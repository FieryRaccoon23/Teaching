using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    [SerializeField]
    private float m_HorizontalSpeed = 5.0f;

    [SerializeField]
    private float m_ForwardSpeed = 2.0f;

    private void Update()
    {
        transform.position = new Vector3(transform.position.x,
                                         transform.position.y + (m_ForwardSpeed * Time.deltaTime),
                                         transform.position.z);

        if (Input.GetKey("left"))
        {
            transform.position = new Vector3(transform.position.x - (m_HorizontalSpeed * Time.deltaTime),
                                             transform.position.y,
                                             transform.position.z);
        }
        else if (Input.GetKey("right"))
        {
            transform.position = new Vector3(transform.position.x + (m_HorizontalSpeed * Time.deltaTime),
                                             transform.position.y,
                                             transform.position.z);
        }
    }
}
