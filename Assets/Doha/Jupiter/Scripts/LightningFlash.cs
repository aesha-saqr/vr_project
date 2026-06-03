using UnityEngine;
using System.Collections;

public class LightningFlash : MonoBehaviour
{
    public Light flashLight;

    void Start()
    {
        InvokeRepeating("Flash", 1f, 3f);
    }

    void Flash()
    {
        StartCoroutine(FlashRoutine());
    }

    IEnumerator FlashRoutine()
    {
        // First Flash
        flashLight.enabled = true;
        yield return new WaitForSeconds(0.15f);

        flashLight.enabled = false;
        yield return new WaitForSeconds(0.05f);

        // Second Flash
        flashLight.enabled = true;
        yield return new WaitForSeconds(0.1f);

        flashLight.enabled = false;
    }
}