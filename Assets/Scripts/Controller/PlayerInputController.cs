using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.WorldToScreenPoint(newAim);
        //마우스랑 스크립트가 붙을 객체와의 방향벡터
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if(newAim.magnitude >=.9f)
        {
            CallLookEvent(newAim);
        }
    }
}
