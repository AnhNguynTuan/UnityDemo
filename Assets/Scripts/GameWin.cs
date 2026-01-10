using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameWin : MonoBehaviour
{
    public SceneManager SceneManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnGameWinButtonClicked()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
