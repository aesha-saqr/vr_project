using UnityEngine;

public class RockRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(
            20 * Time.deltaTime,
            35 * Time.deltaTime,
            15 * Time.deltaTime
        );
    }
}