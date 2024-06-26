using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] public Rigidbody2D character;
    [SerializeField] public PlayerAttributes player;
    [SerializeField] public float characterSpeed;

    public Vector2 characterVector;

    void Update()
    {
        character.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")).normalized * characterSpeed * player.modifierSpeed;
        characterVector = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
    }
}
