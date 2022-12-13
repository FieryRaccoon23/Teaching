using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

[System.Serializable]
public class SaveData
{
    public string objectName;
    public int strength;
    public int intelligence;
    public int agility;

    public SaveData(GameObjectToSave objectToSave)
    {
        objectName = objectToSave.objectName;
        strength = objectToSave.strength;
        intelligence = objectToSave.intelligence;
        agility = objectToSave.agility;
    }
}