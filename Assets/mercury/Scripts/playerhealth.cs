using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public int health = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fragment"))
        {
            health--;

            Debug.Log("Player Hit! Health: " + health);

            if (health <= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }
}