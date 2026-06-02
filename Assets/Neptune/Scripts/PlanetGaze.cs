using UnityEngine;

public class PlanetGaze : MonoBehaviour
{
    public GameObject infoPanel;

    private float timer = 0f;
    public float gazeTime = 2f;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(
            new Vector3(0.5f, 0.5f, 0)
        );

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == transform)
            {
                // يكبر الكوكب
                transform.localScale = originalScale * 1.2f;

                timer += Time.deltaTime;

                if (timer >= gazeTime)
                {
                    infoPanel.SetActive(true);
                }
            }
            else
            {
                // يرجع لحجمه الطبيعي
                transform.localScale = originalScale;

                timer = 0f;
            }
        }
        else
        {
            // يرجع لحجمه الطبيعي
            transform.localScale = originalScale;

            timer = 0f;
        }
    }
}