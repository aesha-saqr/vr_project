using UnityEngine;

public class SampleClick : MonoBehaviour
{
    public GasChallenge challenge;

    void OnMouseDown()
    {
        challenge.CollectSample();
        gameObject.SetActive(false);
    }
}