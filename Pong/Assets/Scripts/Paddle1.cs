using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    //private float movement;
    public bool paddle1Move;
    public float speed = 5f;
  

    void Update()
    {
        if(paddle1Move)
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
        }

    }
}
