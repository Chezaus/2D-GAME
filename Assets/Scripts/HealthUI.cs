using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public PlayerHealth main;
    public CanvasGroup health1;
    public CanvasGroup health2;
    public CanvasGroup health3;
    
    void Update()
    {
        switch(main.playerHP){
            case 3:  
                break;
            case 2: health1.alpha = 0;
                break;
            case 1:  health2.alpha = 0; health1.alpha = 0;
                break;

        }
    }
}
