using UnityEngine;

public class PlanetInteraction : MonoBehaviour
{
    public GameObject canvasUI;

    void OnMouseDown()
    {
        canvasUI.SetActive(true);
    }
}