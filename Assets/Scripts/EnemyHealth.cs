using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] public int health;
    public EnemySpawn spawn;

    void Start()
    {
        if(spawn == null)
        {spawn = GameObject.Find("Enemy Spawn").GetComponent<EnemySpawn>();}
    }

    void FixedUpdate()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);
            spawn.enemiesAlive -= 1;

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == ("Bullet"))
            health -= 1;
    }
}
