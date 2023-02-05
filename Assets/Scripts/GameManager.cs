using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
  public int score = 40;
  public TMP_Text scoreText;
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
}
