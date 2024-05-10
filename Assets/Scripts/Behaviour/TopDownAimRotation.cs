using System;
using UnityEditor.Tilemaps;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        Roatate(direction);
    }

    private void Roatate(Vector2 direction)
    {
        //방향으로 각도를 구한다.
        float rotZ  = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Debug.Log(rotZ);
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}