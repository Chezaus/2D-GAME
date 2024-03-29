using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHealth : MonoBehaviour
{

    [SerializeField] public PlayerAttributes player;
    [SerializeField] public LayerMask layers;

    private int health;

    void Start()
    {
        if(player == null)
        {
            player = GameObject.Find("Player").GetComponent<PlayerAttributes>();        }
        health = player.bulletPenetration;
        Debug.Log(layers);
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.layer != layers)
        {
            health -= 1;
            
        }

        if(other.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            Destroy(this.gameObject);
        }

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

            

}    