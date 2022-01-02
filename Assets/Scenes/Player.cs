using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float steerSpeed = 0.1f;

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
        this.transform.Rotate(0, 0, steerSpeed);
        this.transform.Translate(0, moveSpeed, 0);
    }
}
