using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 startPos;

    public GameObject ball;

    private Vector2 ballPos;

    private Rigidbody2D rb;

    void Start()
    {
        transform.position = startPos;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    public void Reset()
    {
        transform.position = startPos;
        rb.velocity = Vector2.zero;
    }

    void Move()
    {
        ballPos = ball.transform.position;

        if (transform.position.y > ballPos.y)
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime);
        }

        if (transform.position.y < ballPos.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.layer = LayerMask.NameToLayer("Ball Computer");
    }
}
