using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI elementlerini kullanabilmek i�in tan�mlad�k. Burada Text e eri�meyi ama�lad�k.
using UnityEngine.SceneManagement;

public class logicManager : MonoBehaviour
{
    public int playereScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public PipeSpawnerScript spawner;

    [ContextMenu("Increase Score")] // bu sat�r a�a��da yazd���m�z fonksiyona unity �zerinden ula�mam�z� sa�lar. 
    public void addScore(int scoreToAdd)
    {
        playereScore = playereScore + scoreToAdd;
        scoreText.text = playereScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        spawner.isOver = true;
    }
}
