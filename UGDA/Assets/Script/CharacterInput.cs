using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    protected PlayerInput _playerInput;
    protected Vector2 readValue;

    //GoundCheck
    private Vector3 _boxSize;
    private float _maxDistance = 2;
    [SerializeField] private LayerMask _groundCheckLayer;
    void Start()
    {
        _boxSize = new Vector3(0.8f, 0.8f, 0.8f);
    }
    public void OnEnable()
    {
        _playerInput = new PlayerInput();
        _playerInput.Player.Enable();
    }

    public void OnDisable()
    {
        _playerInput.Player.Disable();
    }


    public virtual void Movment()
    {
        readValue = _playerInput.Player.Movment.ReadValue<Vector2>();
    }

    public virtual bool Jump()
    {
        if (_playerInput.Player.Jump.triggered && IsGrounded())
        {
            return true;
        }

        return false;
    }

    public bool IsGrounded()
    {
        //Checking for the ground
        if (Physics.BoxCast(transform.position, _boxSize, -transform.up, transform.rotation, _maxDistance, _groundCheckLayer))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public virtual bool Ability()
    {
        if (_playerInput.Player.Ability.triggered)
        {
            return true;            
        }

        return false;
    }
}
