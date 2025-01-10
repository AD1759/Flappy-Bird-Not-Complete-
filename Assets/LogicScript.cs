using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore;
    public Text scoreText;
    public  GameObject gameOverScreen;

    private void Start()
    {
        gameOverScreen.SetActive(false);
    }


    [ContextMenu("Increase Score")]

    public void addScore(){
        playerScore += 1;
        scoreText.text = "Score: " + playerScore;
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        BirdScript bird = FindAnyObjectByType<BirdScript>();
        if (bird != null)
        {
            Destroy(bird.gameObject);
        }
    }
}
