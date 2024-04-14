using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
   PlayerMovement movement;
   public Animator player;

   private float lastInput;

  void Update()
  {
    if(Input.GetAxisRaw("Vertical") != 0)
    {
      lastInput = Input.GetAxisRaw("Vertical");
    }

    player.SetFloat("vertical", lastInput);

    if(Input.GetAxisRaw("Vertical") > 0)
    {
      player.SetBool("walking", true);
    }
    if(Input.GetAxisRaw("Vertical") < 0)
    {
      player.SetBool("walking", true);
    }
    else
    {
      player.SetBool("walking", false);
    }
  }
}
