using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetector : MonoBehaviour
{
    private Vector2 m_FingerDown;
    private Vector2 m_FingerUp;
    public bool m_DetectSwipeOnlyAfterRelease = false;

    public float SWIPE_THRESHOLD = 20f;

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                m_FingerUp = touch.position;
                m_FingerDown = touch.position;
            }

            //Detects Swipe while finger is still moving
            if (touch.phase == TouchPhase.Moved)
            {
                if (!m_DetectSwipeOnlyAfterRelease)
                {
                    m_FingerDown = touch.position;
                    checkSwipe();
                }
            }

            //Detects swipe after finger is released
            if (touch.phase == TouchPhase.Ended)
            {
                m_FingerDown = touch.position;
                checkSwipe();
            }
        }
    }

    void checkSwipe()
    {
        //Check if Vertical swipe
        if (verticalMove() > SWIPE_THRESHOLD && verticalMove() > horizontalValMove())
        {
            //Debug.Log("Vertical");
            if (m_FingerDown.y - m_FingerUp.y > 0)//up swipe
            {
                OnSwipeUp();
            }
            else if (m_FingerDown.y - m_FingerUp.y < 0)//Down swipe
            {
                OnSwipeDown();
            }
            m_FingerUp = m_FingerDown;
        }

        //Check if Horizontal swipe
        else if (horizontalValMove() > SWIPE_THRESHOLD && horizontalValMove() > verticalMove())
        {
            //Debug.Log("Horizontal");
            if (m_FingerDown.x - m_FingerUp.x > 0)//Right swipe
            {
                OnSwipeRight();
            }
            else if (m_FingerDown.x - m_FingerUp.x < 0)//Left swipe
            {
                OnSwipeLeft();
            }
            m_FingerUp = m_FingerDown;
        }

        //No Movement at-all
        else
        {
            //Debug.Log("No Swipe!");
        }
    }

    float verticalMove()
    {
        return Mathf.Abs(m_FingerDown.y - m_FingerUp.y);
    }

    float horizontalValMove()
    {
        return Mathf.Abs(m_FingerDown.x - m_FingerUp.x);
    }

    //////////////////////////////////CALLBACK FUNCTIONS/////////////////////////////
    void OnSwipeUp()
    {
        Debug.Log("Swipe Up");
    }

    void OnSwipeDown()
    {
        Debug.Log("Swipe Down");
    }

    void OnSwipeLeft()
    {
        Debug.Log("Swipe Left");
    }

    void OnSwipeRight()
    {
        Debug.Log("Swipe Right");
    }
}
