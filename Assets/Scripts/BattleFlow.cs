using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleFlow : MonoBehaviour
{
    public GameObject bgMusic;
    public GameObject gameOverUI;
    public PlayerHealth playerHealth;
    public GameObject gameWinUI;
    private void Start()
    {
        gameOverUI.SetActive(false);
        playerHealth.onDead += OnGameOver;
    }
    private void OnGameOver()
    {
        bgMusic.SetActive(false);
        gameOverUI.SetActive(true);
    }
    private void OnGameWin()
    {
        gameWinUI.SetActive(true);
        bgMusic.SetActive(true);
        playerHealth.gameObject.SetActive(false);
    }
    private void Update()
    {
        if(EnemyHealth.LivingEnemyCount <= 0)
        {
            OnGameWin();    
        }
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
