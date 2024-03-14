using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dashbar : MonoBehaviour
{
    public RoundCounter count;
    float value;
    [SerializeField] Image bar;

    void Update()
    {
        if(count.timeLeft < 0)  {value = 0;}
        else{value = (float)count.timeLeft/count.roundTime;}

        
        bar.fillAmount = value;
    }

}