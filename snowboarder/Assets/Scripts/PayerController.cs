using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerController : MonoBehaviour
{
    [SerializeField]
    float torqueAmount = 1f;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
