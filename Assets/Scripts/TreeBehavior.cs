using UnityEngine;
using TarodevController;

public class TreeBehavior : MonoBehaviour
{
  public int maxHealth = 100;
  public int currentHealth;
  public HealthBar healthBar;
  public GameManager logic;
  public bool treeIsAlive = true;

  void Start()
  {
    currentHealth = maxHealth;
    healthBar.SetMaxHealth(maxHealth);
  }

  void Update()
  {

  }
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "enemy")
    {
      Destroy(other.gameObject);
      currentHealth -= 49;
      healthBar.SetHealth(currentHealth);
    }
    if (currentHealth < 1)
    {
      Destroy(gameObject);
      logic.gameOver();
      treeIsAlive = false;
      GameObject.FindWithTag("Player").GetComponent<PlayerController>().enabled = false;
    }
  }

}
