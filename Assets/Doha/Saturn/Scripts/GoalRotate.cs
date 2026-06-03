using UnityEngine;

public class GoalRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 80 * Time.deltaTime, 0);
    }
}