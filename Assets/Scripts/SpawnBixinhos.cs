using UnityEngine;

public class SpawnBixinhos : MonoBehaviour
{


  public GameObject[] bixinhos;
  public int selectedBixinho = 0;
  public float upThreshold = 1;
  public bool canPlace = true;

  void Start()
  {

  }

  void Update()
  {
    if (Input.GetMouseButtonDown(1))
    {
      selectedBixinho = (selectedBixinho + 1) % bixinhos.Length;
    }

    if (Input.GetKeyDown("space") && canPlace)
    {
      var posicao = transform.position + (Vector3.up * upThreshold);
      var rotacao = Quaternion.identity;
      Instantiate(bixinhos[selectedBixinho], posicao, rotacao);
    }
  }


  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "bixinho")
    {
      canPlace = false;
    }
  }

  void OnTriggerStay2D(Collider2D other)
  {
    if (other.tag == "bixinho")
    {
      canPlace = false;
    }
  }

  void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "bixinho")
    {
      canPlace = true;
    }
  }
}
