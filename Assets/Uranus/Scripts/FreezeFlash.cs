using UnityEngine;

public class FreezeFlash : MonoBehaviour
{
    public Light freezeLight;
    public float flashSpeed = 1f;

    void Update()
    {
        freezeLight.intensity = Mathf.PingPong(Time.time * flashSpeed, 3f);
    }
}