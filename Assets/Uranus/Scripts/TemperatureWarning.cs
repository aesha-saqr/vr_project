using UnityEngine;
using TMPro;

public class TemperatureWarning : MonoBehaviour
{
    public TextMeshProUGUI warningText;
    private bool showWarning = false;

    void Start()
    {
        if (warningText != null)
            warningText.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        if (warningText == null) return;
        showWarning = !showWarning;
        warningText.gameObject.SetActive(showWarning);
        if (showWarning)
            warningText.text = " WARNING: -224°C DETECTED!\nFREEZING ENVIRONMENT!";
    }
}