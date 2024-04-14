using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundCounter : MonoBehaviour
{
    [SerializeField] public float roundTime;

    [SerializeField] EnemySpawn spawn;

    public float timeLeft;
    public int roundNumber;

    void Start()
    {
        roundNumber = 1;
        timeLeft = roundTime;
    }

    void FixedUpdate()
    {
        timeLeft -= Time.fixedDeltaTime;

        if(!spawn.enemyAlive)
        {
            roundNumber += 1;
            Debug.Log("ATTEMPTING TRANSITION");

            if(PlayerPrefs.GetInt("level") <= roundNumber)
            {
                PlayerPrefs.SetInt("level", roundNumber + 1);
                PlayerPrefs.Save();
            }

            SceneManager.LoadScene("lvl_" + roundNumber);


        }
    }
}
