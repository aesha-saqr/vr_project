using UnityEngine;

public class SaturnShowText : MonoBehaviour
{
    public GameObject textObject;
    public AudioSource audioSource;

    public void ShowTheText()
    {
        bool isActive = textObject.activeSelf;

        // Toggle text
        textObject.SetActive(!isActive);

        // Play sound
        if (audioSource != null)
        {
            audioSource.Stop();
            audioSource.Play();
        }
    }
}

