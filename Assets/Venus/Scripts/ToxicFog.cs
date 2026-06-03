using UnityEngine;

public class ToxicFog : MonoBehaviour
{
    public ParticleSystem fog;
    private bool isThick = false;

    void OnMouseDown()
    {
        isThick = !isThick;
        var emission = fog.emission;
        emission.rateOverTime = isThick ? 500 : 100;
    }
}
