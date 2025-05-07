using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    public static GameManager Instance
    {
        get { return gameManager; }
    }

    private int currentScore = 0;
    UIManager_Flappy uiManager;

    public UIManager_Flappy UIManager
    {
        get { return uiManager; }
    }
    private void Awake()
    {
        gameManager = this;
        uiManager = FindObjectOfType<UIManager_Flappy>();
    }

    private void Start()
    {
        uiManager.UpdateScore(0);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        MiniGameScore();    
        uiManager.SetRestart();
        uiManager.SetMainButton();
       
    }

  

    public void AddScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore);
        Debug.Log("Score: " + currentScore);
    }

    public void MiniGameScore()
    {
        PlayerPrefs.SetInt("LastMiniGameScore", currentScore);
        
        int bestScore = PlayerPrefs.GetInt("MiniGameScore", 0); // 저장된 최고 점수 불러오기

        if (currentScore > bestScore)
        {
            PlayerPrefs.SetInt("MiniGameScore", currentScore); // 최고 점수 갱신
           
        }
        PlayerPrefs.Save(); // 즉시 저장



    }

}