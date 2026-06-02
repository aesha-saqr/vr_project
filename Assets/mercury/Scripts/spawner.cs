using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject fragmentPrefab;

    public float spawnRate = 2f;
    public float spawnRange = 10f;

    void Start()
    {
        InvokeRepeating("SpawnFragment", 1f, spawnRate);
    }

    void SpawnFragment()
    {
        Vector3 randomPos = new Vector3(
            Random.Range(-spawnRange, spawnRange),
            transform.position.y,
            Random.Range(-spawnRange, spawnRange)
        );

        Instantiate(fragmentPrefab, randomPos, Quaternion.identity);
    }
}
