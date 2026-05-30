using UnityEngine;

public class MarsPlanetInfo : MonoBehaviour
{
    public GameObject infoPanel;

    private bool isOpen = false;

    void OnMouseDown()
    {
        isOpen = !isOpen;
        infoPanel.SetActive(isOpen);
    }
}