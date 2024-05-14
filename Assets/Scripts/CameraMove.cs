using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private TopDownController controller;
    private Camera camera;

    [SerializeField] private Transform target;

    private Vector3 cameraPosition = Vector3.zero;

    private void Awake()
    {
        camera = GetComponent<Camera>();
        controller = GetComponent<TopDownController>();
    }

    private void Update()
    {
        cameraPosition = new Vector3(target.position.x, target.position.y, -10);
        camera.transform.position = cameraPosition;
    }
}
