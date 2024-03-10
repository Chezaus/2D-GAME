using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHealth : MonoBehaviour
{

    [SerializeField] public int bulletPenetration;

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(this.gameObject);
    }
            

}    