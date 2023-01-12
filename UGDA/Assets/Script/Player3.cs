using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : Character
{
    public float Character3Speed;
    public float Character3Jump;

    // Start is called before the first frame update
    void Start()
    {
        movmentSpeed = Character3Speed;
        jumpHeight = Character3Jump;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
