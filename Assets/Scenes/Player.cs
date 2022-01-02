using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float steerSpeed = 1f;

    [SerializeField]
    float moveSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello there my frinend !");
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = -1 * Input.GetAxis("Horizontal") * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;

        this.transform.Rotate(0, 0, steerAmount);
        this.transform.Translate(0, moveAmount, 0);
    }
}
