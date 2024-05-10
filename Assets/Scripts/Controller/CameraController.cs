using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : TopDownController
{
    [SerializeField]
    private float cameraSpeed;
    [SerializeField]
    private Transform player;

    private void Start()
    {
        cameraSpeed = 100f;
    }
    private void Update()
    {
        Vector3 dir = player.position - transform.position;
        Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
        transform.Translate(moveVector);
    }
}