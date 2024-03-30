using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    [SerializeField] public GameObject bullet;
    [SerializeField] public GameObject character;
    [SerializeField] public float bulletSpeed;
    [SerializeField] public float fireRate;

    private float cooldown;

    void Update()
    {
        if(cooldown >= fireRate)
        {
            if(Input.GetButtonDown("Fire"))
            {
            
                GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x - character.gameObject.transform.position.x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y - character.gameObject.transform.position.y).normalized * bulletSpeed;
                cooldown = 0f;
            }

        }

        Debug.Log(new Vector2 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x - character.gameObject.transform.position.x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y - character.gameObject.transform.position.y));


        
    }

    void FixedUpdate()
    {
        if(cooldown < fireRate)
        {
            cooldown += Time.fixedDeltaTime;
        }
    }
}
