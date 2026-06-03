using UnityEngine;
using TMPro;

public class GasChallenge : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeLeft = 30f;
    private int samplesCollected = 0;
    private bool gameOver = false;

    void Update()
    {
        if (gameOver) return;
        
        timeLeft -= Time.deltaTime;
        timerText.text = "TOXIC ATMOSPHERE!\nCollect Gas Samples: " + samplesCollected + "/3\nTime: " + Mathf.CeilToInt(timeLeft) + "s";
        
        if (timeLeft <= 0)
        {
            gameOver = true;
            timerText.text = "YOU DIED - TOXIC GAS!";
            timerText.color = Color.red;
        }
    }

    public void CollectSample()
    {
        if (gameOver) return;
        samplesCollected++;
        if (samplesCollected >= 3)
        {
            gameOver = true;
            timerText.text = "MISSION COMPLETE!\nAll Samples Collected!";
            timerText.color = Color.green;
        }
    }
}