using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] public Rigidbody2D rb2d;
    [SerializeField] public float speed;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        SetRandomTrajectory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetRandomTrajectory() 
    {
        Vector2 force = Vector2.zero;
        force.y = Random.Range(-1f, 1f);
        force.x = -1f;

        rb2d.AddForce(force.normalized * speed);
    }
}
