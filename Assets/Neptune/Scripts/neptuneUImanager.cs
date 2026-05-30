using UnityEngine;
using TMPro;

public class neptuneUImanager : MonoBehaviour
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

                "NEPTUNE\n" +

                "• Farthest planet from the Sun\n" +
                "• Known for its deep blue color\n" +
                "• Neptune has the strongest winds in the Solar System";
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

                "• Neptune takes 165 Earth years\n" +
                "  to orbit the Sun!\n\n" +

                "• Winds on Neptune can reach\n" +
                "  over 2,000 km per hour!";
        }
        else
        {
            funFactText.text = "";
        }
    }
}