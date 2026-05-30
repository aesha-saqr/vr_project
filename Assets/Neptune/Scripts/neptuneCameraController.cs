using UnityEngine;

public class neptuneCameraController : MonoBehaviour
{
    public Transform target;

    public float rotateSpeed = 5f;
    public float zoomSpeed = 5f;

    private float distance;

    void Start()
    {
        distance = Vector3.Distance(transform.position, target.position);
    }

    void Update()
    {
        // Rotate
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X") * rotateSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * rotateSpeed;

            transform.RotateAround(target.position, Vector3.up, mouseX);

            transform.RotateAround(
                target.position,
                transform.right,
                -mouseY
            );
        }

        // Zoom
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        transform.position += transform.forward * scroll * zoomSpeed;

        transform.LookAt(target);
    }
}