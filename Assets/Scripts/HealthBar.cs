using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Health health;
    public RectTransform mask;
    private float originalWidth;
    private void Start()
    {
        originalWidth = mask.sizeDelta.x;
        UpdateHealthValue();
        health.onHealthChange += UpdateHealthValue;
    }
    private void UpdateHealthValue()
    {
        float scale = (float)health.baseHealth / health.defaultHealth;
        mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y);
    }
}
