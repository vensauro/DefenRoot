using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
  public int playerScore;
  public GameObject gameOverScreen;
  public static bool gameIsOver = false;

  public void restartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void gameOver()
  {
    gameIsOver = true;
    gameOverScreen.SetActive(true);
  }
}
