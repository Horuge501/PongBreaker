using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreBall : MonoBehaviour
{
    [SerializeField] private GameObject brick;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ball Computer"))
        {
            print("Pasale");
            brick.GetComponent<Collider2D>().isTrigger = true;
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("Ball Player"))
        {
            brick.GetComponent<Collider2D>().isTrigger = false;
        }
    }
}
