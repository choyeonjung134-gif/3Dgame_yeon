using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 5f;
    public float gravity = -20f;
    public float mouseSensitivity = 0.2f;

    private Vector2 lookInput;


    private Vector2 moveInput;
    private float verticalVelocity;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    public void OnJump(InputValue value)
    {
        if (value.isPressed && controller.isGrounded)
        {
            verticalVelocity = jumpPower;
        }
    }

    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
    }


    void Update()
    {
        transform.Rotate(0f, lookInput.x * mouseSensitivity, 0f);

        if (controller.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }


        if (controller.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = transform.forward * moveInput.y + transform.right * moveInput.x;
        move = move * moveSpeed;
        move.y = verticalVelocity;

        controller.Move(move * Time.deltaTime);


    }
}
