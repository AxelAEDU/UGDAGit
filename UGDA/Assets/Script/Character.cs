using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    protected Rigidbody rB;
    protected float movmentSpeed;
    protected float jumpHeight;
    protected PlayerInput _playerInput;


    //GoundCheck
    private Vector3 _boxSize;
    private float _maxDistance = 2;
    [SerializeField] private LayerMask _groundCheckLayer;

    private void Awake()
    {
        Physics.gravity = new Vector3(0, -300f, 0);
        rB = GetComponent<Rigidbody>();
        GetComponentInChildren<Collider>();
        _boxSize = new Vector3(1, 1, 1);
    }
    private void Start()
    {

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

    private void Update()
    {
        Jump();
    }
    void FixedUpdate()
    {
        Movment();

    }
    void Movment()
    {
        //Making the Character Move
        Vector2 readValue = _playerInput.Player.Movment.ReadValue<Vector2>();
        rB.velocity = movmentSpeed * readValue.y * transform.forward + (transform.right * readValue.x) * movmentSpeed;
    }

    public void Jump()
    {
        //Make the Character to Jump and will check if it´s grounded
        if (IsGrounded ())
        {
            if (_playerInput.Player.Jump.triggered)
            {
                rB.AddForce(new Vector2(0, jumpHeight), ForceMode.Impulse);
            }
        }
    }

    public bool IsGrounded()
    {
        //Checking for the ground
        if (Physics.BoxCast(transform.position,_boxSize,-transform.up,transform.rotation, _maxDistance, _groundCheckLayer))
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    public void OnAbility(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("Ability");
        }
    }


}
