using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player3 : Character
{
    public float Character3Speed;
    public float Character3Jump;
    public ParticleSystem P3Particlesystem;

    private void Awake()
    {
        rB = GetComponentInParent<Rigidbody>();
        //Changeing the movment speed
        this.movmentSpeed = this.Character3Speed;
        //Changing the jump height
        this.jumpHeight = this.Character3Jump;

        particlesystem = P3Particlesystem;
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
