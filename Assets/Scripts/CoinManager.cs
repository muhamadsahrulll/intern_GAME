using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;

    private int coinCount = 0; // Jumlah coin
    public TextMeshProUGUI coinText; // UI TextMeshPro untuk menampilkan jumlah koin

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateCoinUI();
    }

    // Fungsi untuk menambah koin
    public void AddCoin(int amount)
    {
        coinCount += amount;
        UpdateCoinUI();
    }

    // Update UI
    private void UpdateCoinUI()
    {
        coinText.text = "Coins: " + coinCount;
    }
}
