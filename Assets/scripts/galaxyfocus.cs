using UnityEngine;

public class galaxyfocus : MonoBehaviour
{
    public Transform cameraTransform;

    public float moveSpeed = 10f;

    void Update()
    {
        // Ray خارج من الكاميرا
        Ray ray = new Ray(
            cameraTransform.position,
            cameraTransform.forward
        );

        RaycastHit hit;

        // لو الراي لمس المجرة
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == transform)
            {
                Debug.Log("HIT GALAXY");

                // الكاميرا تقرب للمجرة
                cameraTransform.position =
                    Vector3.Lerp(
                        cameraTransform.position,

                        // مكان قريب من المجرة
                        transform.position - transform.forward * 15f,

                        Time.deltaTime * moveSpeed
                    );
            }
        }
    }
}