using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI elementlerini kullanabilmek için tanýmladýk. Burada Text e eriþmeyi amaçladýk.
using UnityEngine.SceneManagement;

public class logicManager : MonoBehaviour
{
    public int playereScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public PipeSpawnerScript spawner;

    [ContextMenu("Increase Score")] // bu satýr aþaðýda yazdýðýmýz fonksiyona unity üzerinden ulaþmamýzý saðlar. 
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
