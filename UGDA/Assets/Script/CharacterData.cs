using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharacterData
{
    public float[] position;

    //Getting position from were SaveAndLoadScript are attached to
    public CharacterData (SaveAndLoad snl)
    {
        position = new float[3];
        position[0] = snl.transform.position.x;
        position[1] = snl.transform.position.y;
        position[2] = snl.transform.position.z;
    }
}
