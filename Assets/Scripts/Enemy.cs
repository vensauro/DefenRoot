using UnityEngine;


namespace RootFence
{
  public class Enemy : MonoBehaviour
  {

    public GameObject target;


    public Direction direction = Direction.Right;
    private Vector3 vectorDirection;
    public float enemySpeed = 3;
    public LayerMask _groundLayer;
    public float height = 6;


    void Start()
    {

    }

    void Update()
    {
      vectorDirection = direction == Direction.Left ? Vector3.left : Vector3.right;
      transform.localScale = new Vector3(direction == Direction.Left ? -1 : 1, 1, 1);
      transform.position += vectorDirection * enemySpeed * Time.deltaTime;

      // RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.up * -1, height, _groundLayer);
      // if (ray.)
      // {
      //   transform.position += Vector3.up * -10 * Time.deltaTime;
      // }

    }

    // void OnDrawGizmos()
    // {
    //   Gizmos.color = Color.red;
    //   Vector3 direction = transform.TransformDirection(Vector3.up) * -1 * height;
    //   Gizmos.DrawRay(transform.position, direction);
    // }

    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "bullet")
      {
        Destroy(other.gameObject);
      }
    }
  }
}
