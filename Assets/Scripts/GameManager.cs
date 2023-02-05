using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public int score = 40;
  public TMP_Text scoreText;
  public int playerScore;
  public GameObject gameOverScreen;
  public static bool gameIsOver = false;
  // Start is called before the first frame update
  void Start()
  {
    scoreText.text = score.ToString();
  }

  public static GameManager getGameManager()
  {
    return GameObject.FindGameObjectWithTag("manager").GetComponent<GameManager>();
  }

  public void addPoints(int point)
  {
    score += point;
    scoreText.text = score.ToString();
  }

  // Update is called once per frame
  void Update()
  {

  }

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
