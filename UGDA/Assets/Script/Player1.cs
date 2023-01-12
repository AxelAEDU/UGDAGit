using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : Character
{


    public float Character1Speed;
    public float Character1Jump;

    // Start is called before the first frame update
    void Start()
    {
        movmentSpeed = Character1Speed;
        jumpHeight = Character1Jump;


    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    public void Jump()
    {
        if (_playerInput.Player.Jump.triggered && IsGrounded())
        {
            rB.AddForce(new Vector2(0, Character1Jump), ForceMode.Impulse);
            Debug.Log("Jumping");            
        }
    }





}
