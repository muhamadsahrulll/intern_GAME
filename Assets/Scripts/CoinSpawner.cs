using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // Prefab untuk coin
    public Transform spawnPoint;  // Titik spawn utama
    public float spawnInterval = 2f; // Interval spawn koin
    public float spawnRangeX = 2.5f; // Batas posisi X untuk spawn koin

    void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    IEnumerator SpawnCoins()
    {
        while (true)
        {
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);
            Vector3 spawnPosition = new Vector3(randomX, spawnPoint.position.y, 0f);

            // Spawn coin
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
