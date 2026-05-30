using UnityEngine;
using TMPro;

public class MercuryUIManager : MonoBehaviour
{
    public TextMeshProUGUI infoText;
    public TextMeshProUGUI funFactText;

    public AudioSource clickSound;

    public void ShowPlanetInfo()
    {
        clickSound.Play();

        if (infoText.text == "")
        {
            infoText.text =

                "MERCURY\n" +

                "• Closest planet to the Sun\n" +
                "• Smallest planet in the Solar System\n" +
                "• A year on Mercury is only 88 Earth days";
        }
        else
        {
            infoText.text = "";
        }
    }

    public void ShowFunFact()
    {
        clickSound.Play();

        if (funFactText.text == "")
        {
            funFactText.text =

                "• Mercury has almost no atmosphere\n" +
                "  so temperatures change extremely fast!\n\n" +

                "• One day on Mercury lasts longer\n" +
                "  than its whole year!";
        }
        else
        {
            funFactText.text = "";
        }
    }
}