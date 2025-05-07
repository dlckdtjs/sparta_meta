using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;





public class UIManager : MonoBehaviour
{
   

    

    public TextMeshProUGUI scoreText;
    int score = 0;



    private void Awake()
    {
        score = PlayerPrefs.GetInt("MiniGameScore", 0);
    }

    private void Start()
    {
        
        scoreText.text = score.ToString();



    }

  
 
}
