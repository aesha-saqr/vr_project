using UnityEngine;

public class SaturnCameraCinematic : MonoBehaviour
{
    public Transform target;

    public float orbitSpeed = 4f;

    public float normalDistance = 18f;
    public float zoomDistance = 6f;

    public float smoothSpeed = 2f;

    private float currentDistance;
    private bool isZoomed = false;

    void Start()
    {
        currentDistance = normalDistance;
    }

    void Update()
    {
        if (target == null) return;

        // Click anywhere to zoom
        if (Input.GetMouseButtonDown(0))
        {
            isZoomed = !isZoomed;
        }

        // Smooth zoom
        float targetDistance =
            isZoomed ? zoomDistance : normalDistance;

        currentDistance = Mathf.Lerp(
            currentDistance,
            targetDistance,
            smoothSpeed * Time.deltaTime
        );

        // Orbit around Saturn
        transform.RotateAround(
            target.position,
            Vector3.up,
            orbitSpeed * Time.deltaTime
        );

        // Set camera position
        Vector3 offset =
            transform.forward * -currentDistance;

        transform.position =
            target.position + offset;

        // Always look at Saturn
        transform.LookAt(target);
    }
}