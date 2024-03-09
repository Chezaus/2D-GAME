using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField] public GameObject enemy;
    [SerializeField] public float spawnRate;

    private float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if(cooldown >= spawnRate)
        {
            Instantiate(enemy,new Vector2(1,1), Quaternion.identity);
            cooldown = 0;
        }
    }

    void FixedUpdate()
    {
        if(cooldown < spawnRate)
        {
            cooldown += Time.fixedDeltaTime;
        }
    }
}
