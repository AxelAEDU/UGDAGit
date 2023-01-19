using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1 : Character
{
    public float Character1Speed;
    public float Character1Jump;
    public ParticleSystem P1Particlesystem;
    private void Awake()
    {
        rB = GetComponentInParent<Rigidbody>();
        //Changeing the movment speed
        movmentSpeed = Character1Speed;
        //Changing the jump height
        jumpHeight = Character1Jump;

        particlesystem = P1Particlesystem;
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
