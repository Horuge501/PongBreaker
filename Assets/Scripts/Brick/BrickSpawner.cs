using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    [SerializeField] private float countdownObstacle;

    private float timer;
    private PoolScript obstaclePool;

    void Start()
    {
        timer = 0;
        obstaclePool = GetComponent<PoolScript>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= countdownObstacle)
        {
            GameObject obj = obstaclePool.RequestObject();

            float randX = Random.Range(0.8f, 7f);
            float randY = Random.Range(-4.11f, 4.11f);
            obj.transform.position = new Vector3(randX, randY, 0);
            timer = 0;
        }
    }
}
