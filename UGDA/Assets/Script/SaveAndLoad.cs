using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    public void SaveCharacter()
    {
        SaveSystem.SaveCharacter(this);
    }

    public void LoadCharacter()
    {
        CharacterData data = SaveSystem.LoadCharacter();

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }

    public void NewGame()
    {
        Vector3 position;
        position.x = position.x = 0;
        position.y = position.y = 1;
        position.z = position.z = 0;
        transform.position = position;

        SaveSystem.SaveCharacter(this);
    }
}
