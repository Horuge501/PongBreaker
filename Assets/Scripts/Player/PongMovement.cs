using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PongMovement : MonoBehaviour
{
    private PongController controller;

    [SerializeField] private float speed;

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
}
