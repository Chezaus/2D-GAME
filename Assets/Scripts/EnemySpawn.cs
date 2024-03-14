using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField] public GameObject enemy;
    [SerializeField] public float roundTime;
    [SerializeField] public int maxEnemy;
    [SerializeField] public float spawnRate;

    [SerializeField] public RoundCounter round;

    private float cooldown;

    public bool enemyAlive = true;
    private bool collisionCheck = true;

    void Start()
    {
        enemyAlive = true;
    }
    
    void Update()
    {
        if(cooldown >= spawnRate && collisionCheck && round.timeLeft > 0)
        {
            Instantiate(enemy,this.gameObject.transform.position, Quaternion.identity);
            cooldown = 0;
        }
    }

    void FixedUpdate()
    {
        if(cooldown < spawnRate)
        {
            cooldown += Time.fixedDeltaTime;
        }

        if(round.timeLeft < 0 && GameObject.FindWithTag("Enemy") == null)
        {
            Debug.Log("ENEMY DIED");
            enemyAlive = false;
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
