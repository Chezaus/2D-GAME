using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerAI : MonoBehaviour
{
    public GameObject puddle;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GameObject recentPuddle = Instantiate(puddle, this.gameObject.transform.position, Quaternion.identity);
            recentPuddle.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Obstacle");
            Destroy(this.gameObject);
        }
    }
}
