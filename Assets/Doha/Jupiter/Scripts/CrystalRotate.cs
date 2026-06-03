using UnityEngine;

public class CrystalRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 200 * Time.deltaTime, 0);
    }
}