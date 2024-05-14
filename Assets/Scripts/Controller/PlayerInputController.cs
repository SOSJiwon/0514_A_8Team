using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    public Camera camera;

    public void Awake()
    {
        camera = Camera.main;
    }

    public void OnMove(InputValue direction)
    {
        Vector2 moveInput = direction.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
}
