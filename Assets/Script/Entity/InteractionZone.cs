using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteractionZone : MonoBehaviour
{
    
    [SerializeField] private Button interactionButton;
    [SerializeField] private string sceneToLoad;

    private void Start() 
    {
        interactionButton.onClick.AddListener(LoadScene);

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        Button button = other.GetComponentInChildren<Button>();
        if (other.CompareTag("Player"))
        {



            interactionButton.gameObject.SetActive(true);




        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionButton.gameObject.SetActive(false);
        }
    }
    private void LoadScene()
    {
        
            SceneManager.LoadScene(sceneToLoad);
        
    }
}
