using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUp : MonoBehaviour
{
    [SerializeField] PlayerAttributes player;

    [SerializeField] RoundCounter time;

    private int cooldown1;
    private int cooldown2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("PowerUp")) 
        {
            if(other.gameObject.CompareTag("powerUp1"))
            {
                cooldown1 = (int)time.timeLeft - 10;
                player.modifierSpeed = 2;
                Destroy(other.gameObject);
            }
            if(other.gameObject.CompareTag("powerUp2"))
            {
                cooldown2 = (int)time.timeLeft - 10;
                player.bulletPenetration += 1;
                Destroy(other.gameObject);
                Debug.Log(player.bulletPenetration);
            }
            
            Debug.Log("LAYER");
        }

        Debug.Log("BROKEN");
    }

    void FixedUpdate()
    {
        if(cooldown1 > time.timeLeft)
        {
            player.modifierSpeed = 1;
        }
        if(cooldown2 > time.timeLeft)
        {
            player.bulletPenetration -= 1;
        }
    }
    
}
