using UnityEngine;

public class ShowText : MonoBehaviour
{
    public GameObject textObject;
    public AudioSource audioSource;

    public void ShowTheText()
    {
        bool isActive = textObject.activeSelf;

        textObject.SetActive(!isActive);

        audioSource.Play();
    }
}