using UnityEngine;

public class AllyTower : MonoBehaviour
{

  public float cooldown = 0;
  public float maxTime = 5;
  public GameObject bullet;
  // Start is called before the first frame update
  void Start()
  {

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
    // Tem que fazer com que isso funcione para novas torres também.
    // Apenas torres que já foram spawnadas receberam o buff, novas
    // não irão receber.
    if (Input.GetKeyDown(KeyCode.K) && maxTime > 1)
    {
      upgradeCooldown(1);
    }
    if (Input.GetKeyDown(KeyCode.J) && Bullet.currentMoveSpeed < 30)
    {
      Bullet.upgradeSpeed(5);
    }
  }

  // Função para criar a bala que as torres aliadas atiram.
  void shoot()
  {
    Instantiate(bullet, transform.position, Quaternion.identity);
  }

  // Função para diminuir o cooldown dos tiros das torres aliadas.
  void upgradeCooldown(float cooldownTosubtract)
  {
    maxTime -= cooldownTosubtract;
  }


}
