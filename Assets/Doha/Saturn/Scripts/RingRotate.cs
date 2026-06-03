using UnityEngine;

public class RingRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 60 * Time.deltaTime, 0);
    }
}