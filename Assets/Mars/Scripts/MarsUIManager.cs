using UnityEngine;
using TMPro;

public class MarsUIManager : MonoBehaviour
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

                "MARS\n\n" +

                "• Fourth planet from the Sun\n" +
                "• Known as the Red Planet\n" +
                "• Has the largest volcano in the solar system";
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

                "• Mars has two moons:\n" +
                "  Phobos and Deimos\n\n" +

                "• A day on Mars lasts\n" +
                "  24 hours and 37 minutes";
        }
        else
        {
            funFactText.text = "";
        }
    }
}