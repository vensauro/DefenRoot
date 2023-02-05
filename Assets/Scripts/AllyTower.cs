using UnityEngine;

public class AllyTower : MonoBehaviour
{

  public float cooldown = 0;
  public float maxTime = 5;
  public static float currentMaxTime = 5;
  public GameObject bullet;
  public GameObject bulletStart;
  // Start is called before the first frame update
  void Start()
  {
    maxTime = AllyTower.currentMaxTime;
    transform.localScale = new Vector3(transform.position.x > 0 ? -1 : 1, 1, 1);
  }

  // Update is called once per frame
  void Update()
  {
    if (cooldown < maxTime)
    {
      cooldown += Time.deltaTime;
    }
    else
    {
      cooldown = 0;
      shoot();
    }

    if (Input.GetKeyDown(KeyCode.K) && currentMaxTime > 1)
    {
      upgradeCooldown(1);
      maxTime -= 1;
    }
    if (Input.GetKeyDown(KeyCode.J) && Bullet.currentMoveSpeed < 30)
    {
      Bullet.upgradeSpeed(5);
    }
  }

  // Função para criar a bala que as torres aliadas atiram.
  void shoot()
  {
    Instantiate(bullet, bulletStart.transform.position, Quaternion.identity);
  }

  // Função para diminuir o cooldown dos tiros das torres aliadas.
  static void upgradeCooldown(float cooldownTosubtract)
  {
    AllyTower.currentMaxTime -= cooldownTosubtract;
  }
}
