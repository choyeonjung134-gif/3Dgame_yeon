using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector2 movelnout;
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void OnMove(InputValue value)
    {
        movelnout = value.Get<Vector2>();
    }


    void Update()
    {
        controller.Move(movelnout * Time.deltaTime);
    }
}
