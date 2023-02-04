using UnityEngine;


namespace RootFence
{
  public class Enemy : MonoBehaviour
  {

    public GameObject alvo;


    public Direction direction = Direction.Right;
    public float enemySpeed = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      var aaa = direction == Direction.Left ? Vector3.left : Vector3.right;
      transform.position += aaa * enemySpeed * Time.deltaTime;
    }
  }
}
