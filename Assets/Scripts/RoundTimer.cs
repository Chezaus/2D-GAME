using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dashbar : MonoBehaviour
{
    public EnemySpawn spawn;
    float value;
    [SerializeField] Image bar;

    void Update()
    {
        if(spawn.enemiesAlive < 0)  {value = 1;}
        else{value = (float)spawn.enemiesAlive/spawn.maxEnemy;}

        
        bar.fillAmount = value;
    }

}