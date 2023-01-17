using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : Character
{
    public float Character2Speed;
    public float Character2Jump;
    public ParticleSystem P2Particlesystem;

    private void Awake()
    {
        rB = GetComponentInParent<Rigidbody>();
        //Changeing the movment speed
        this.movmentSpeed = this.Character2Speed;
        //Changing the jump height
        this.jumpHeight = this.Character2Jump;

        particlesystem = P2Particlesystem;
    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Jump();
        Ability();
    }
}
