using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerController : MonoBehaviour
{
    [SerializeField]
    float torqueAmount = 1f;

    [SerializeField]
    float boostSpeed = 20f;

    [SerializeField]
    float baseSpeed = 10f;


    SurfaceEffector2D surfaceEffector2D;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();

        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();

    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.surfaceEffector2D.speed = this.boostSpeed;
        }
        else
        {
            this.surfaceEffector2D.speed = this.baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.rb2d.AddTorque(-torqueAmount);
        }
    }
}
