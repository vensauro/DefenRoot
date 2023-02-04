using UnityEngine;

public class SpawnBixinhos : MonoBehaviour
{


  public GameObject[] bixinhos;
  public int selectedBixinho = 0;
  public float upThreshold = 1;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetMouseButtonDown(1))
    {
      selectedBixinho = (selectedBixinho + 1) % bixinhos.Length;
    }

    if (Input.GetKeyDown("space"))
    {
      var posicao = transform.position + (Vector3.up * upThreshold);
      var rotacao = Quaternion.identity;
      Instantiate(bixinhos[selectedBixinho], posicao, rotacao);
    }

  }
}
