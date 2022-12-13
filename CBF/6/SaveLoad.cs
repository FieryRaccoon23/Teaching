using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.TextCore.Text;
using Unity.VisualScripting;

public static class SaveLoad
{
    public static void SaveGameData(GameObjectToSave character)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Game.mygameCBF";

        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData charData = new SaveData(character);

        formatter.Serialize(stream, charData);
        stream.Close();
    }

    public static SaveData LoadGameData()
    {
        string path = Application.persistentDataPath + "/Game.mygameCBF";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData data = formatter.Deserialize(stream) as SaveData;

            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Error: Save file not found in " + path);
            return null;
        }
    }
}