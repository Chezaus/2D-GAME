using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] public int health;

    public PowerUp getPowerUp;
    public EnemySpawn spawn;

    void Start()
    {
        getPowerUp = GameObject.Find("Power Ups").GetComponent<PowerUp>();
    }

    void FixedUpdate()
    {
        if(health <= 0)
        {
            
            if(Random.Range(1,100) < 10)
            {
                Instantiate(getPowerUp.GeneratePowerUp(),this.gameObject.transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);

        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == ("Bullet"))
            health -= 1;
    }
}
