using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ 
    [SerializeField]
    private float speed = 15f;
    [SerializeField]
    private float jumpForce = 15f;
    private Rigidbody2D rb;

    void Start() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        //movement
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += speed * Time.deltaTime * movement;

        //jump
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
}