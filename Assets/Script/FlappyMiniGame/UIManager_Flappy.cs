using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager_Flappy : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Button restartButton;
    public Button mainButton;

    public void Start()
    {
        

        if (scoreText == null)
        {
            Debug.LogError("scoreText is null");
            return;
        }

        restartButton.gameObject.SetActive(false);
        mainButton.gameObject.SetActive(false);

        mainButton.onClick.AddListener(LoadScene);
        restartButton.onClick.AddListener(RestartGame);
    }

    public void SetRestart()
    {
        restartButton.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void SetMainButton()
    {
        mainButton.gameObject.SetActive(true);

    }

    private void LoadScene()
    {

        SceneManager.LoadScene("MainScene");

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}