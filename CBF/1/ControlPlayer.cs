using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    [SerializeField]
    private float m_Speed = 5.0f;

    private void Update()
    {
        // How inputs work
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("Fire1");
        //}

        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Debug.Log("Fire1");
        //}

        if(Input.GetKey("left"))
        {
            // Either translate
            transform.Translate(Vector3.left * m_Speed * Time.deltaTime);

            // Or change position using vector
            //transform.position = new Vector3(transform.position.x - (m_Speed * Time.deltaTime),
            //                                 transform.position.y,
            //                                 transform.position.z);
        }
        else if(Input.GetKey("right"))
        {
            // Either translate
            transform.Translate(Vector3.right * m_Speed * Time.deltaTime);

            // Or change position using vector
            //transform.position = new Vector3(transform.position.x + (m_Speed * Time.deltaTime),
            //                                 transform.position.y,
            //                                 transform.position.z);
        }
    }
}
