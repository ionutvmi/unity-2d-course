using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    float destroyDelay = 0.5f;


    [SerializeField]
    Color32 packagePickedUpColor = new Color32(1, 1, 1, 0);

    [SerializeField]
    Color32 noPackageColor = new Color32(0, 0, 0, 0);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collition detected.");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package picked up !");

            this.spriteRenderer.color = this.packagePickedUpColor;

            Destroy(other.gameObject, destroyDelay);
        }
    }
}
