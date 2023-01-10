using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    public PlayerInput input;
    public Rigidbody rB;
    protected float speed;

    private PlayerInput playerInput;


    private void Start()
    {

    }

    public void OnEnable()
    {
        playerInput = new PlayerInput();
        playerInput.Player.Enable();

    }

    public void OnDisable()
    {
        playerInput.Player.Disable();
    }

    private void FixedUpdate()
    {
        Movment();
    }
    void Movment()
    {
        Vector2 readValue = playerInput.Player.Movment.ReadValue<Vector2>();
        rB.velocity = (transform.forward * readValue.y).normalized * speed + (transform.right * readValue.x).normalized * speed;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("JUmpong");
    }

}
