using UnityEngine;

public class DangerFlash : MonoBehaviour
{
    public Light dangerLight;
    public float flashSpeed = 2f;

    void Update()
    {
        dangerLight.intensity = Mathf.PingPong(Time.time * flashSpeed, 3f);
    }
}