using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour
{
    //private float movement;
    public bool paddle2Move;
    public float speed = 5f;


    void Update()
    {
        if (paddle2Move)
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);
        }

    }
}