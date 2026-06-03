using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 10 * Time.deltaTime, 0);
    }
}