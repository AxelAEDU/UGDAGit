using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Character
{
    public float Character2Speed;
    public float Character2Jump;

    // Start is called before the first frame update
    void Start()
    {
        movmentSpeed = Character2Speed;
        jumpHeight = Character2Jump;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
