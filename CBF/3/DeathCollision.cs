using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Death");
        Debug.Log(collision.gameObject.ToString());
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }
}
