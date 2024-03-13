using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHealth : MonoBehaviour
{

    [SerializeField] public int bulletPenetration;
    [SerializeField] public LayerMask layers;

    private int health;

    void Start()
    {
        health = bulletPenetration;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.layer != layers)
        {
            health -= 1;
        }

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

            

}    