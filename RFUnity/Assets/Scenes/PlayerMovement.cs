using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jms;
    public float ms;
    public Rigidbody2D rb;
    bool IsGrounded = false;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsGrounded == true)
            {
                rb.AddForce(Vector2.up * jms);
                IsGrounded = false;
            }
        }
   

        // Vector2 run = transform.right * ms * Time.fixedDeltaTime;
        // rb.MovePosition(rb.position + run);


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (IsGrounded == false) {
                IsGrounded = true;
            }
        }
    }
}
