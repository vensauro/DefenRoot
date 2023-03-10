using UnityEngine;

public class SpawnerAllyTower : MonoBehaviour
{


  public GameObject[] allyTowers;
  public int selectedTower = 0;
  public float upThreshold = 1;
  public bool canPlace = true;
  GameManager manager;

  void Start()
  {
    manager = GameManager.getGameManager();
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(1))
    {
      selectedTower = (selectedTower + 1) % allyTowers.Length;
    }

    if (Input.GetKeyDown("space") && canPlace && manager.score >= 20)
    {
      manager.addPoints(-20);
      var position = transform.position + (Vector3.up * upThreshold);
      var rotation = Quaternion.identity;
      Instantiate(allyTowers[selectedTower], position, rotation);
    }
  }


  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "allyTower")
    {
      canPlace = false;
    }
  }

  void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "allyTower")
    {
      canPlace = false;
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "allyTower")
    {
      canPlace = true;
    }
  }
}
