using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private int m_Coins = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            collision.gameObject.SetActive(false);
            m_Coins++;

            Debug.Log("You collected a coin. Total coins: " +  m_Coins.ToString());
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Death")
        {
            Debug.Log("You died");
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        transform.position = new Vector3 (0, 0, 0); 
    }
}
