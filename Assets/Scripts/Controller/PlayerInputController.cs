using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        //worldToScreePoint 랑 ScreeToWorldPoint의 차이
        Vector2 worldPos = mainCamera.ScreenToWorldPoint(newAim);
        //마우스랑 스크립트가 붙을 객체와의 방향벡터
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if(newAim.magnitude >=.9f)
        {
            CallLookEvent(newAim);
        }
    }
}
