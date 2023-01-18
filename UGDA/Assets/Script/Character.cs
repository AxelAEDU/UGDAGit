using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : CharacterInput
{
    protected Rigidbody rB;
    protected float movmentSpeed;
    protected float jumpHeight;

    protected ParticleSystem particlesystem;

    private void Awake()
    {
        Physics.gravity = new Vector3(0, -300f, 0);
        rB = GetComponent<Rigidbody>();
        GetComponentInChildren<Collider>();
        GetComponentInChildren<ParticleSystem>();
    }

    private void Update()
    {

    }
    void FixedUpdate()
    {
        Movment();
    }
    public override void Movment()
    {
        base.Movment();
        //Making the Character Move
        rB.velocity = movmentSpeed * readValue.y * transform.forward + (transform.right * readValue.x) * movmentSpeed;
    }

    public override bool Jump()
    {
        bool canJump = base.Jump();
        //Make the Character to Jump
        if (canJump)
        {
            rB.AddForce(new Vector2(0, jumpHeight), ForceMode.Impulse);
            return true;
        }
        return false;
    }

    public override bool Ability()
    {
        bool useAbility = base.Ability();
        //Make the Character to use Ability
        if (useAbility)
        {
            particlesystem.Play();
            return true;
        }
        return false;
    }

}
