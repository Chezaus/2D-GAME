using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public PlayerHealth player;

    void Start()
    {
        if(player == null)
        {
            player = GameObject.Find("Player").GetComponent<PlayerHealth>();
        }
    }
    private float cooldown;
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(cooldown < 0)
            {
                player.playerHP -= 1;
                cooldown = 1;
            }
        }
    }

    void Update()
    {
        cooldown -= Time.deltaTime;
    }
}
