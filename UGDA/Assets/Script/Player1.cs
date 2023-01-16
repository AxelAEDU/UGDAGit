using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : Character
{
    public float Character1Speed;
    public float Character1Jump;

    private void Awake()
    {
        rB = GetComponentInParent<Rigidbody>();
        //Changeing the movment speed
        this.movmentSpeed = this.Character1Speed;
        //Changing the jump height
        this.jumpHeight = this.Character1Jump;
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Jump();
    }

}
