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
    private float angle;

    void Update()
    {
        if(cooldown >= fireRate)
        {
            if(Input.GetButton("Fire"))
            {
            
                GameObject recentBullet = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
                recentBullet.GetComponent<Rigidbody2D>().velocity = new Vector2 (Camera.main.ScreenToWorldPoint(Input.mousePosition).x - character.gameObject.transform.position.x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y - character.gameObject.transform.position.y).normalized * bulletSpeed;
                recentBullet.transform.eulerAngles = new Vector3 (0, 0, angle-90);
                
                cooldown = 0f;
            }
        }     
    }

    void FixedUpdate()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        Vector2 direction = mousePosition - transform.position;
        angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3 (0, 0, angle-90);

        if(cooldown < fireRate)
        {
            cooldown += Time.fixedDeltaTime;
        }
    }
}
