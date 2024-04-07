using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
   PlayerMovement movement;
   public Animator player;

  void Update()
  {
    if(Input.GetAxisRaw("Vertical") < 0)
    {
        player.SetFloat("vertical", -1);
    }
    Debug.Log(Input.GetAxisRaw("Vertical"));
  }
}
