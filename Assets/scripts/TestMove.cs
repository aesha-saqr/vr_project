using UnityEngine;

public class TestMove : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Camera.main.transform.position =
                new Vector3(
                    transform.position.x,
                    transform.position.y,
                    transform.position.z - 5f
                );

            Camera.main.transform.LookAt(transform);

            Debug.Log("WORKED");
        }
    }
}