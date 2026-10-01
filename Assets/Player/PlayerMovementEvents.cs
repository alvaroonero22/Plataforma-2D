using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementEvents : MonoBehaviour
{
    PlayerMovement playerMovement;
    public bool isGrounded;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        isGrounded = false;
    }

   /* public void OnMove(InputValue value)
    {
        Debug.Log("On move: " + value.Get<Vector2>());
        playerMovement.movementInput = value.Get<Vector2>();
    }
   */

    public void OnMoveHorizontal(InputValue value)
    {
        playerMovement.movementInput = value.Get<float>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    public void OnColissionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed && isGrounded == true)
        {
            playerMovement.Jump();
        }
    }
}