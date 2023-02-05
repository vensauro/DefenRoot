using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tiro das torres aliadas.
public class Bullet : MonoBehaviour
{

  public float moveSpeed = 5;
  public static float currentMoveSpeed = 5;
  public float deadZone = 75;
  // Start is called before the first frame update
  void Start()
  {
    moveSpeed = Bullet.currentMoveSpeed;
  }

  // Update is called once per frame
  void Update()
  {
    // Saiu do mapa, destroi o objeto para não gastar memória.
    if (transform.position.x < -deadZone || transform.position.x > deadZone)
    {
      Destroy(gameObject);
    }
    // Se a torre aliada foi spawnada na esquerda, as balas vão para esquerda,
    // mesma coisa para direita.
    if (transform.position.x < 0)
    {
      transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
    else
    {
      transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
  }

  // Função para aumentar a velocidade dos tiros das torres aliadas.
  public static void upgradeSpeed(float speedToAdd)
  {
    currentMoveSpeed += 5;
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "enemy")
    {
      Destroy(other.gameObject);
    }
  }
}
