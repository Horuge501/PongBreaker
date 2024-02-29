using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] public Rigidbody2D rb2d;
    [SerializeField] public float speed;
    [SerializeField] private Vector2 startPos;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        transform.position = startPos;
        SetRandomTrajectory();
    }

    public void Reset()
    {
        transform.position = startPos;
        rb2d.velocity = Vector2.zero;
        SetRandomTrajectory();
    }

    private void SetRandomTrajectory() 
    {
        Vector2 force = Vector2.zero;
        force.y = Random.Range(-1f, 1f);
        force.x = -1f;

        rb2d.AddForce(force.normalized * speed);
    }
}
