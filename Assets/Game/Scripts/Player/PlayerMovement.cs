using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 15f;

    [SerializeField]
    private float jumpForce = 15f;

    private Rigidbody2D rb;


    void Start() => rb = GetComponent<Rigidbody2D>();

    public void ProcessMovement(Vector3 movement)
    {
        transform.position += speed * Time.deltaTime * movement;
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