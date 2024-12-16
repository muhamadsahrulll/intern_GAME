using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // Kecepatan gerak pemain
    private Rigidbody2D rb; // Komponen Rigidbody2D untuk kontrol fisika
    private float moveInput; // Input horizontal

    void Start()
    {
        // Mengambil komponen Rigidbody2D dari GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Mengambil input horizontal (-1: kiri, 1: kanan)
        moveInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // Menggerakkan pemain ke kiri/kanan menggunakan Rigidbody2D
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
}
