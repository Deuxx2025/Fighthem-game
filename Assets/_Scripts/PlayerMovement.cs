using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float speed;
   public float inputX;
   public float inputY;
   private Rigidbody2D _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = Vector3.Normalize(new Vector2(inputX, inputY));

        _rb.linearVelocity = moveDirection * speed;
    }
}
