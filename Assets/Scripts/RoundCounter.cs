using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundCounter : MonoBehaviour
{
    [SerializeField] public float roundTime;

    public float timeLeft;
    public int roundNumber;

    void Start()
    {
        roundNumber = 0;
        timeLeft = roundTime;
    }

    void FixedUpdate()
    {
        timeLeft -= Time.fixedDeltaTime;
    }
}
