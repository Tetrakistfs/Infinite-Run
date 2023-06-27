using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerBody;
    private PlayerInput playerInput;
    [SerializeField] private AudioSource movementSound;
    private void Awake()
    {
        playerBody = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();

        PlayerControls playercontrols = new PlayerControls();
        EnableMovement(playercontrols);
    }

    private void EnableMovement(PlayerControls playercontrols)
    {
        playercontrols.Player.Enable();
        playercontrols.Player.Movement.performed += MovementPerformed;
    }
    // private void DisableMovement(PlayerControls playercontrols)
    // {
    //     playercontrols.Player.Disable();
    //     playercontrols.Player.Movement.canceled += MovementPerformed;
    // }

    private void MovementPerformed(InputAction.CallbackContext context)
    {
        // Debug.Log(context);
        movementSound.Play();
        Vector2 inputVector = new Vector2(context.ReadValue<float>(), 0);
        float speed = 5f;
        playerBody.velocity = new Vector2(inputVector.x, inputVector.y) * speed;

        // Debug.Log(context.ReadValue<float>());
    }
}
