using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBG : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRender;

    

    void Update()
    {
        // Menggeser tekstur secara vertikal di sumbu Y
        backgroundRender.material.mainTextureOffset += new Vector2(0f, backgroundSpeed * Time.deltaTime);
    }
}
