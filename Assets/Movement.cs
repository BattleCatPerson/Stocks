using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public float price;
    public float rate;
    public float half;

    public SpriteRenderer spriteRenderer;
    public AudioSource audioSource;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        half = price / 2;

        spriteRenderer.gameObject.SetActive(false);
        audioSource.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 45);
            price += rate * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 0, -45);
            price -= rate * Time.deltaTime;
        }
        else transform.rotation = Quaternion.Euler(0, 0, 0);

        rb.velocity = transform.right * speed;
        if(price < half)
        {
            spriteRenderer.gameObject.SetActive(true);
            audioSource.gameObject.SetActive(true);
        }

    }
}
