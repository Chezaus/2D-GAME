using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeMenu : MonoBehaviour
{
    [SerializeField] GameObject Canvas;

    public bool menuActive = false;
    private float cooldown;

    void Start()
    {
        Canvas.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !menuActive && cooldown > 0.1)
        {
            menuActive = true;
            Canvas.SetActive(true);
             Debug.Log("menu open");
             cooldown = 0;
        }

        if(Input.GetKeyDown(KeyCode.Escape) && menuActive && cooldown > 0.1)
        {
            menuActive = false;
            Canvas.SetActive(false);
             Debug.Log("menu closed");
             cooldown = 0;
        }

        cooldown += Time.fixedDeltaTime;
    }
}
