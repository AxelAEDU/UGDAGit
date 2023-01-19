using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveCharacter (SaveAndLoad snl)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/character.ch";
        FileStream stream = new FileStream(path, FileMode.Create);

        CharacterData data = new CharacterData(snl);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static CharacterData LoadCharacter()
    {
        string path = Application.persistentDataPath + "/character.ch";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            CharacterData data = formatter.Deserialize(stream) as CharacterData;
            stream.Close();

            return data;

        }
        else
        {
            Debug.LogError("Save file do not exits in " + path);
            return null;
        }
    }
}
