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

    private void Awake()
    {
        Physics.gravity = new Vector3(0, -300f, 0);
        rB = GetComponentInParent<Rigidbody>();
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

    private void FixedUpdate()
    {
        Movment();
    }
    void Movment()
    {
        Vector2 readValue = _playerInput.Player.Movment.ReadValue<Vector2>();
        rB.velocity = (transform.forward * readValue.y) * movmentSpeed + (transform.right * readValue.x) * movmentSpeed;
    }



    public void OnJump()
    {
        //if (context.phase == InputActionPhase.Performed)
        //{
        //    Debug.Log("Jumping");

        //    Jump();
        //}
    }
    public bool IsGrounded()
    {
        return transform.Find("GroundCheck").GetComponent<GroundCheck>().isGrounded;
    }


    public void OnAbility(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("Ability");
        }
    }


}
