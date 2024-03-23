using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] public GameObject powerUp1;
    [SerializeField] public GameObject powerUp2;

    public GameObject GeneratePowerUp()
    {
        if(Random.Range(0,3) < 2)
        {
            return powerUp1;
        }
        else
        {
            return powerUp2;
        }
    }
}
