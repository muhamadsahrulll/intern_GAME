using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; // Prefab obstacle
    public Transform spawnPoint; // Titik spawn utama (O)
    public float spawnInterval = 1f; // Interval spawn dalam detik
    public float spawnRangeX = 2.5f; // Batas posisi X (di kiri dan kanan)

    void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            // Menghitung posisi X acak dalam batas kiri dan kanan
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);

            // Menentukan posisi spawn baru (di titik O dengan posisi X acak)
            Vector3 spawnPosition = new Vector3(randomX, spawnPoint.position.y, 0f);

            // Spawn obstacle
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);

            // Tunggu sesuai interval
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
