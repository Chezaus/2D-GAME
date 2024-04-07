using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathScreen : MonoBehaviour
{
    public GameObject Canvas;

    void Start()
    {
        Canvas.SetActive(false);
    }
    
    public void OnDeath()
    {
        Canvas.SetActive(true);
        Invoke("Respawn",3);
    }
    
    void Respawn()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
