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

    public void OnLook(InputValue direction)
    {
        Vector2 newAim = direction.Get<Vector2>();
        Vector2 WorldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (WorldPos - (Vector2)transform.position).normalized;
        CallLookEvent(newAim);
    }
}
