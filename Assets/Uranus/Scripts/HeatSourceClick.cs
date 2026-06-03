using UnityEngine;

public class HeatSourceClick : MonoBehaviour
{
    public SurvivalChallenge survival;

    void OnMouseDown()
    {
        survival.ReachHeatSource();
    }
}