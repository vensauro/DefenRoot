using UnityEngine;

  public class TreeBehavior : MonoBehaviour
  {
    public int maxHealth = 10;
  public int currentHealth;
  public HealthBar healthBar;
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
      currentHealth -= 1;
      healthBar.SetHealth(currentHealth);
    }
  }

  }
