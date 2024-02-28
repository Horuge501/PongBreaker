using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PongMovement : MonoBehaviour
{
    private PongController controller;

    [SerializeField] private float speed;
    public float maxBounceAngle;

    private Rigidbody2D rb;

    private void Awake()
    {
        controller = new PongController();
    }

    void Start()
    {
        controller.Enable();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        Vector2 movementInput = controller.Player.Movement.ReadValue<Vector2>();

        float moveY = movementInput.y;

        Vector2 movement = new Vector2(0, moveY);

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null) 
        {
            Vector3 paddlePosition = transform.position;
            Vector2 contactPosition = collision.GetContact(0).point;

            float offset = Mathf.Abs(paddlePosition.y) - Mathf.Abs(contactPosition.y);
            float width = collision.otherCollider.bounds.size.y / 2;

            float currentAngle = Vector2.SignedAngle(Vector2.right, ball.rb2d.velocity);
            float bounceAngle = (offset / width) * maxBounceAngle;
            float newAngle = Mathf.Clamp(currentAngle + bounceAngle, -maxBounceAngle, maxBounceAngle);

            Quaternion rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
            ball.rb2d.velocity = rotation * Vector2.right * ball.rb2d.velocity.magnitude;
        }
    }
}
