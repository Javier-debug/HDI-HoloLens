using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public Transform startMarker;
    public Transform endMarker;
    public int robotRoot = -1;

    // Movement speed in units per second.
    public float speed = 1.0F;

    private bool animationSucceded = false;

    void Start()
    {
        // Keep a note of the time the movement started.
    }

    IEnumerator timeToPass()
    {
        if(robotRoot == 0)
        {
            yield return new WaitForSeconds(9);
            robotRoot = 1;
            yield return new WaitForSeconds(2);
            animationSucceded = false;
            robotRoot = -1;
            StopCoroutine(timeToPass());
        }
        else
        {
            StopCoroutine(timeToPass());
        }
    }

    // Move to the target end position.
    void Update()
    {
        if (robotRoot == 0 || robotRoot == -1)
        {
            if (animationSucceded == false)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, endMarker.position, step);

                if (transform.position == endMarker.position)
                {
                    animationSucceded = true;
                    StartCoroutine(timeToPass());
                }
            }
        }
        else
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(startMarker.position.x, 1f, startMarker.position.z), step);
        }
    }
}
