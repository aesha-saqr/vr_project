using UnityEngine;
using UnityEngine.SceneManagement;

public class SafeZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("TRIGGER WORKED");
            SceneManager.LoadScene(1);
        }
    }
}