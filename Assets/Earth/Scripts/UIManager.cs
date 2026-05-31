using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
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

                "EARTH\n" +

                "• Third planet from the Sun\n" +
                "• 71% covered by water\n" +
                "• The only known planet with life";
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

                "• Right now, you are spinning with Earth\n" +
                "  at about 1,000 miles per hour!\n\n" +

                "• The sunlight reaching Earth right now\n" +
                "  actually left the Sun about 8 minutes ago!";
        }
        else
        {
            funFactText.text = "";
        }
    }
}