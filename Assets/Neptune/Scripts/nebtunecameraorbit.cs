using UnityEngine;

public class nebtunecameraorbit : MonoBehaviour
{
    public Transform target;

    public float orbitSpeed = 10f;
    public float zoomSpeed = 5f;

    public float minDistance = 2f;
    public float maxDistance = 10f;

    void Update()
    {
        // دوران حول الكوكب
        transform.RotateAround(target.position, Vector3.up, orbitSpeed * Time.deltaTime);

        // الكاميرا تبص على الكوكب
        transform.LookAt(target);

        // الزوم بالماوس
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll != 0)
        {
            Vector3 direction = transform.forward;

            float distance = Vector3.Distance(transform.position, target.position);

            if ((scroll > 0 && distance > minDistance) ||
                (scroll < 0 && distance < maxDistance))
            {
                transform.position += direction * scroll * zoomSpeed;
            }
        }
    }
}