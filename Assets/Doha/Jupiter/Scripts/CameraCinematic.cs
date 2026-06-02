using UnityEngine;

public class CameraCinematic : MonoBehaviour
{
    public Transform target;
    public float orbitSpeed = 4f; // ?? We slowed down the orbit speed slightly for better readability

    public float normalDistance = 18f;
    public float zoomDistance = 11f; // ?? We increased the zoom distance so Jupiter stays smaller and leaves space for text
    public float speed = 3f;

    private float currentDistance;
    private bool isZoomed = false;

    void Start()
    {
        currentDistance = normalDistance;

        if (target != null)
        {
            transform.position = target.position - new Vector3(0, 0, currentDistance);
        }
    }

    void Update()
    {
        if (target == null) return;

        // 1. Continuous orbital rotation around the planet
        transform.RotateAround(target.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // 2. Detect mouse click on the planet
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == target)
                {
                    isZoomed = !isZoomed;
                }
            }
        }

        // 3. Smoothly interpolate between normal and zoom distances
        float targetDistance = isZoomed ? zoomDistance : normalDistance;
        currentDistance = Mathf.Lerp(currentDistance, targetDistance, speed * Time.deltaTime);

        // 4. Apply position and look at the target planet
        Vector3 direction = (transform.position - target.position).normalized;
        transform.position = target.position + direction * currentDistance;
        transform.LookAt(target);
    }
}