using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField] public GameObject enemy;
    [SerializeField] public int maxEnemy;
    [SerializeField] public float spawnRate;

    public int enemiesAlive;

    private int enemiesLeft;
    private float cooldown;
    private bool collisionCheck = true;
    

    // Start is called before the first frame update
    void Start()
    {
        enemiesLeft = maxEnemy;
    }
    void Update()
    {
        if(cooldown >= spawnRate && collisionCheck && enemiesLeft > 0)
        {
            Instantiate(enemy,this.gameObject.transform.position, Quaternion.identity);
            cooldown = 0;
            enemiesLeft -= 1;
        }
    }

    void FixedUpdate()
    {
        if(cooldown < spawnRate)
        {
            cooldown += Time.fixedDeltaTime;
        }

        if(GameObject.FindWithTag("Enemy") == null)
        {
            enemiesLeft = maxEnemy;
            enemiesAlive = maxEnemy;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == ("Enemy"))
        {
            collisionCheck = false;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == ("Enemy"))
        {
            collisionCheck = true;
        }
    }
}
