using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float steerSpeed = 1f;

    [SerializeField]
    float moveSpeed = 7f;

    [SerializeField]
    float boostSpeed = 15f;

    [SerializeField]
    float normalMoveSpeed = 7f;

    DateTime boostExpirationTime = DateTime.Now;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello there my frinend !");
    }

    // Update is called once per frame
    void Update()
    {

        if (DateTime.Now > this.boostExpirationTime)
        {
            this.moveSpeed = this.normalMoveSpeed;
        } else
        {
            this.moveSpeed = this.boostSpeed;
        }

        float verticalAxis = Input.GetAxis("Vertical");
        if (verticalAxis != 0)
        {
            float moveAmount = verticalAxis * moveSpeed * Time.deltaTime;
            this.transform.Translate(0, moveAmount, 0);
        }

        float horizAxis = Input.GetAxis("Horizontal");

        // only steer if the car is moving
        if (horizAxis != 0 && verticalAxis != 0)
        {
            float steerAmount = -1 * horizAxis * steerSpeed * Time.deltaTime;
            this.transform.Rotate(0, 0, steerAmount);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            this.boostExpirationTime = DateTime.Now.AddSeconds(30);
        }
    }
}
