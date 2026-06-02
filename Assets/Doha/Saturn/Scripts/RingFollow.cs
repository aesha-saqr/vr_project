using UnityEngine;

public class RingFollow : MonoBehaviour
{
    public Transform planet;

    void LateUpdate()
    {
        transform.position = planet.position;

        transform.rotation = Quaternion.Euler(
            75f,
            planet.rotation.eulerAngles.y,
            0f
        );
    }
}