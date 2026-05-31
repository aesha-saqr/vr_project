
using UnityEngine;

public class SaturnShowButtons : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;

    public GameObject text1;
    public GameObject text2;

    private bool buttonsVisible = false;

    private void OnMouseDown()
    {
        buttonsVisible = !buttonsVisible;

        button1.SetActive(buttonsVisible);
        button2.SetActive(buttonsVisible);

        if (!buttonsVisible)
        {
            text1.SetActive(false);
            text2.SetActive(false);
        }
    }
}

