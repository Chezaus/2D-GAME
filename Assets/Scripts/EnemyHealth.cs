using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] public int health;
    public EnemySpawn spawn;

    void FixedUpdate()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == ("Bullet"))
            health -= 1;
    }
}
