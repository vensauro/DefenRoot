using UnityEngine;

namespace RootFence
{
  public class SpawnEnemy : MonoBehaviour
  {

    public GameObject[] bixinhos;
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
        var posicao = transform.position + (Vector3.up * upThreshold);
        var rotacao = Quaternion.identity;

        var randomIndex = Random.Range(0, bixinhos.Length);
        var bixinEnemy = bixinhos[randomIndex].GetComponent<Enemy>();
        // bixinEnemy.enemySpeed = 10;
        bixinEnemy.direction = direction;
        Instantiate(bixinEnemy, posicao, rotacao);
        lastTime = 0;
      }
    }
  }
}
