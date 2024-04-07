using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public int playerHP;
    [SerializeField] public DeathScreen deathScreen;
    void FixedUpdate()
    {
        if(playerHP <= 0)
        {
            deathScreen.OnDeath();
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == ("Enemy"))
        {
            playerHP -= 1;
            Destroy(other.gameObject);
        }
            
    }
}
