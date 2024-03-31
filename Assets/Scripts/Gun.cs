using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] public GameObject bullet;
    [SerializeField] public float bulletSpeed;
    [SerializeField] public float fireRate;

    private float cooldown;

    void Update()
    {
        if(cooldown >= fireRate)
        {
<<<<<<< Updated upstream:Assets/Scripts/Gun.cs
            if(Input.GetAxisRaw("AltVertical") != 0 || Input.GetAxisRaw("AltHorizontal") != 0)
=======
            if(Input.GetButton("Fire"))
>>>>>>> Stashed changes:Assets/Scripts/PlayerAim.cs
            {
            
                GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxisRaw("AltVertical"),Input.GetAxisRaw("AltHorizontal")).normalized * bulletSpeed;
                cooldown = 0f;
            }
<<<<<<< Updated upstream:Assets/Scripts/Gun.cs

        }
        
=======
        }     
>>>>>>> Stashed changes:Assets/Scripts/PlayerAim.cs
    }

    void FixedUpdate()
    {
        if(cooldown < fireRate)
        {
            cooldown += Time.fixedDeltaTime;
        }
    }
}
