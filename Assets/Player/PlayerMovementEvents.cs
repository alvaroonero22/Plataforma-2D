using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementEvents : MonoBehaviour
{
    PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    //  public void OnMove(InputValue value)
    //{
    //   Debug.Log("Move event triggered with value: " + value.Get<Vector2>());
    //  playerMovement.movementInput = value.Get<Vector2>();
    //

    public void OnMoveHorizontal(InputValue value)
    {
        playerMovement.movementInput = value.Get<float>();

    }
    public void OnJump(InputValue value)
    {
        int 
    }
}

