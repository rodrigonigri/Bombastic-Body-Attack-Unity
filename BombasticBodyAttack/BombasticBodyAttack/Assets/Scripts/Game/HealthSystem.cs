using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    // the UI text for the health count
    public TextMeshProUGUI txt_LifeCount;

    // the default health count (used for initialization)
    public int defaultHealthCount;

    // the current health count
    public int healthCount;

    // init the health system (reset the health count)
    public void Init(){
        healthCount = defaultHealthCount;
        txt_LifeCount.text = healthCount.ToString();
        
    }

    // lose health count
    public void LoseHealth(){
        if (healthCount < 1){
            return;
        }
        healthCount--;
        txt_LifeCount.text = healthCount.ToString();

        CheckHealthCount();
    }


    // Check health cout for losing
    void CheckHealthCount(){
        if (healthCount < 1){
            // lose the game
            Debug.Log("You Lose");
            // Call reset values and stop the game from the manager
            SceneManager.LoadScene("GameOver");
        }
        
    }

    public int GetHealthCount(){
        return healthCount;
    }
    
}
