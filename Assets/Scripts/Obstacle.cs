using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed = 5f; // Kecepatan gerak obstacle
    public float destroyY = -6f; // Posisi Y di mana obstacle dihancurkan

    void Update()
    {
        // Menggerakkan obstacle ke bawah
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // Jika obstacle melewati posisi bawah, destroy
        if (transform.position.y <= destroyY)
        {
            Destroy(gameObject);
        }
    }

    // Trigger ketika obstacle menyentuh player
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Kena! Player Mati.");
            // Tambahkan logika kematian player di sini
            Destroy(other.gameObject); // Jika ingin langsung menghancurkan player
        }
    }
}
