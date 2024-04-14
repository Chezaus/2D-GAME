using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField] public GameObject enemy;
    [SerializeField] public float roundTime;
    [SerializeField] public int maxEnemy;
    [SerializeField] public float maxSpawnRate;
    [SerializeField] public float minSpawnRate;
     [SerializeField] public float maxEnemyGroups;
    [SerializeField] public float minEnemyGroups;

    [SerializeField] public Transform[] spawnPoints;

    [SerializeField] public RoundCounter round;

    private float cooldown;
    private float spawnRate = 1;
    

    public bool enemyAlive = true;
    private bool collisionCheck = true;

    void Start()
    {
        enemyAlive = true;
        Debug.Log(this.gameObject.transform.position);
    }
    
    void Update()
    {
        if(cooldown >= spawnRate && collisionCheck && round.timeLeft > 0)
        {
            for(int i = 0;i < Random.Range(minEnemyGroups,maxEnemyGroups); i++)
            {
                int randomSpawn = Random.Range(0,spawnPoints.Length);
                Vector3 spawnPoint = new Vector3(
                spawnPoints[randomSpawn].position.x + Random.Range(-1,1), 
                spawnPoints[randomSpawn].position.y + Random.Range(-1,1), 
                spawnPoints[randomSpawn].position.z); 
                Instantiate(enemy,spawnPoint, Quaternion.identity);
                Debug.Log(spawnPoint);
            }
            
            spawnRate = Random.Range(minSpawnRate,maxSpawnRate);
            
            cooldown = 0;
        }
    }

    void FixedUpdate()
    {
            cooldown += Time.fixedDeltaTime;
     
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
