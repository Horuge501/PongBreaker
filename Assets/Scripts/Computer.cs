using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    [SerializeField] private float speed;

    public GameObject ball;

    private Vector2 ballPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
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
