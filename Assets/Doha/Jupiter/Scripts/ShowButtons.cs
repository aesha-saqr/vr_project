using UnityEngine;

public class ShowButtons : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;

    private bool buttonsVisible = false;

    private void OnMouseDown()
    {
        buttonsVisible = !buttonsVisible;

        button1.SetActive(buttonsVisible);
        button2.SetActive(buttonsVisible);
    }
}