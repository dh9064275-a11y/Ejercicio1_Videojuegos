using UnityEngine;


public class Player_ : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;


    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }


    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }
}
