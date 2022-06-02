using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector3 IsMovement()
    {
        float hMovementInput = Input.GetAxis("Horizontal");
        return new Vector3(hMovementInput, 0f, 0f);
    }

    public bool IsJumpButtonDown()
    {
        return Input.GetButtonDown("Jump");
    }

    public bool IsAttackButtonDown()
    {
        return Input.GetKeyDown(KeyCode.E);
    }
}
