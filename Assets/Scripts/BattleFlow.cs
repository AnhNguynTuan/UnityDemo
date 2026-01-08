using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    public GameObject bgMusic;
    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    void Start()
    {
        gameOverUI.SetActive(false);
        playerHealth.onDead += OnGameOver;
    }
    private void OnGameOver()
    {
        bgMusic.SetActive(false);
        gameOverUI.SetActive(true);
    }
    void Update()
    {
        
    }
}
