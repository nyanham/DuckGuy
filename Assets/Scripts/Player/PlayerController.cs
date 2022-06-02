using UnityEngine;


[RequireComponent(typeof(PlayerMovement))]
[RequireComponent (typeof(PlayerInput))]
public class PlayerController : MonoBehaviour
{
    PlayerMovement playerMovement;
    PlayerInput playerInput;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        playerMovement.Movement(playerInput.IsMovement());

        //jump
        if (playerInput.IsJumpButtonDown())
        {
            playerMovement.Jump();
        }

        //basic attack
        if (playerInput.IsAttackButtonDown())
        {
            playerMovement.Attack();
        }
        
    }
}
