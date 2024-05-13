using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : TopDownController
{
    [SerializeField]
    private float cameraSpeed;
    [SerializeField]
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        cameraSpeed = 100f;
    }
    private void Update()
    {
        if (player != null)
        {
            Vector3 dir = player.transform.position - transform.position;
            Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, 0.0f);
            transform.Translate(moveVector);
        }
        else
        {
            player = GameManager.Instance.character;
        }
    }
}
