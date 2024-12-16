using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float moveSpeed = 3f; // Kecepatan coin bergerak ke bawah
    public float destroyY = -6f; // Posisi Y di mana coin dihancurkan

    void Update()
    {
        // Coin bergerak ke bawah
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // Hancurkan coin jika melewati batas bawah
        if (transform.position.y <= destroyY)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Tambahkan coin ke player
            CoinManager.instance.AddCoin(1);

            // Hancurkan coin
            Destroy(gameObject);
        }
    }
}
