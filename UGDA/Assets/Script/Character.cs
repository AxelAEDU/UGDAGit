using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    //public PlayerInput input;
    public Rigidbody rB;
    public GameObject Caracter1;
    public GameObject Caracter2;
    public GameObject Caracter3;

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

    public void SwitchCharaterTo1()
    {
        Caracter1.SetActive(true);
        Caracter2.SetActive(false);
        Caracter3.SetActive(false);
    }
    public void SwitchCharaterTo2()
    {
        Caracter2.SetActive(true);
        Caracter1.SetActive(false);
        Caracter3.SetActive(false);
    }
    public void SwitchCharaterTo3()
    {
        Caracter3.SetActive(true);
        Caracter2.SetActive(false);
        Caracter1.SetActive(false);
    }

}
