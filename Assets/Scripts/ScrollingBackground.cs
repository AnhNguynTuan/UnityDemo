using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public Renderer bGRenderer;
    public float speed;
    void Update()
    {
        bGRenderer.material.mainTextureOffset = new Vector2(0,Time.time*speed);
    }
}
