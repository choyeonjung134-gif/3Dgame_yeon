using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 5f;
    public float gravity = 20f;

   

    private Vector2 movelnput;
    private float verticalVelocity;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void OnMove(InputValue value)
    {
        movelnput = value.Get<Vector2>();
    }

    public void Onjump(InputValue value)
    {
        if(value.isPressed && controller.isGrounded)
        {
            verticalVelocity = jumpPower;
        }
    }


    void Update()
    {
        if(controller.isGrounded &&verticalVelocity < 0f)
        {
            verticalVelocity = 2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = new Vector3(movelnput.x, 0,movelnput.y);
        move = move * moveSpeed;
        move.y = verticalVelocity;

        controller.Move(movelnput * Time.deltaTime);
    }
}
