using UnityEngine;

public class PlanetInfo : MonoBehaviour
{
    public GameObject infoPanel;

    private bool isOpen = false;

    void OnMouseDown()
    {
        isOpen = !isOpen;
        infoPanel.SetActive(isOpen);
    }
}