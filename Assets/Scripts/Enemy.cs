using UnityEngine;


namespace RootFence
{
  public class Enemy : MonoBehaviour
  {

    public GameObject target;


    public Direction direction = Direction.Right;
    public float enemySpeed = 3;
    void Start()
    {

    }

    void Update()
    {
      var aaa = direction == Direction.Left ? Vector3.left : Vector3.right;
      transform.position += aaa * enemySpeed * Time.deltaTime;
    }

  }
}
