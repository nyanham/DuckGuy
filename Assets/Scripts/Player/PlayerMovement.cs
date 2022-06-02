using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    
    private float speed = 4f;
    private float jumpForce = 18f;

    private Rigidbody2D rb;

    private Animator animator;
    private SpriteRenderer spriteRenderer;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void Movement(Vector3 movement)
    {

        if (movement.x != 0 && Input.GetKeyDown(KeyCode.LeftShift))
        {
            
            transform.position += (speed * 4) * Time.deltaTime * movement;

            animator.SetBool("isRuning", true);

            if (movement.x > 0) spriteRenderer.flipX = true;

            else spriteRenderer.flipX = false;

        }
        else if (movement.x != 0 && !Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position += speed * Time.deltaTime * movement;
            animator.SetBool("isWalking", true);

            if (movement.x > 0) spriteRenderer.flipX = true;

            else spriteRenderer.flipX = false;
        }

        else
        {
            animator.SetBool("isRuning", false);
            animator.SetBool("isWalking", false);
        }

    }


    public void Jump()
    {
        if (Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    public void Attack()
    {
        GetComponentInChildren<IAttack>(true).Attack();
    }
}