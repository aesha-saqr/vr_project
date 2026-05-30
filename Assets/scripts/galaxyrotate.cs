using UnityEngine;

public class galaxyrotate : MonoBehaviour
{
    public float rotationSpeed = 20f;

    void Update()
    {
        // Rotate around Z axis
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}