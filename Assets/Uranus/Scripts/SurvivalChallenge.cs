using UnityEngine;
using TMPro;

public class SurvivalChallenge : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public GameObject heatSource;
    public float timeLeft = 10f;
    private bool gameOver = false;
    private bool won = false;

    void Update()
    {
        if (gameOver) return;
        
        timeLeft -= Time.deltaTime;
        timerText.text = "FREEZING! Survive: " + Mathf.CeilToInt(timeLeft) + "s\nFind the Heat Source!";
        
        if (timeLeft <= 0)
        {
            gameOver = true;
            timerText.text = "YOU DIED - TOO COLD!";
            timerText.color = Color.red;
        }
    }

    public void ReachHeatSource()
    {
        if (gameOver) return;
        won = true;
        gameOver = true;
        timerText.text = "YOU SURVIVED!";
        timerText.color = Color.green;
    }
}