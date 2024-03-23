using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUp : MonoBehaviour
{
    [SerializeField] PlayerMovement movement;

    [SerializeField] RoundCounter time;

    private int cooldown1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("PowerUp")) 
        {
            if(other.gameObject.CompareTag("powerUp1"))
            {
                cooldown1 = (int)time.timeLeft - 10;
                movement.modifierSpeed = 2;
                Destroy(other.gameObject);

                
            }
            

        }
    }

    void FixedUpdate()
    {
        if(cooldown1 > time.timeLeft)
        {
            movement.modifierSpeed = 1;
            Debug.Log("SLOW");
        }
    }
    
}
