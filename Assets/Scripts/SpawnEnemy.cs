using UnityEngine;

namespace RootFence
{
  public class SpawnEnemy : MonoBehaviour
  {
    public GameObject[] enemies;
    private float lastTime = 0;
    public int spawnTime = 3;
    public float upThreshold = -3.57f;
    public Direction direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (lastTime < spawnTime)
      {
        lastTime += Time.deltaTime;
      }
      else
      {
        var position = transform.position + (Vector3.up * upThreshold);
        var rotation = Quaternion.identity;

        var randomIndex = Random.Range(0, enemies.Length);
        var enemy = enemies[randomIndex].GetComponent<Enemy>();
        // enemy.enemySpeed = 10;

        enemy.direction = direction;
        Instantiate(enemy, position, rotation);
        lastTime = 0;
      }

      if (LogicScript.gameIsOver)
      {
        GetComponent<SpawnEnemy>().enabled = false;
      }
    }
  }
}
