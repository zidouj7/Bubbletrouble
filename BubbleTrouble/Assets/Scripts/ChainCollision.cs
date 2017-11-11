using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    public static int Score = 0;

    public void Start()
    {
        Score = 0;
    }

    // Use this for initialization
    public void OnTriggerEnter2D(Collider2D col)
    {
        Chain.isFired = false;

        if(col.tag == "Ball")
        {
            Score++;

            col.GetComponent<Ball>().Split();
        }

    }
}

