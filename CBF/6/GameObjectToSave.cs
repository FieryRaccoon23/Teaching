using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameObjectToSave : MonoBehaviour
{
    public string objectName;
    public int strength;
    public int intelligence;
    public int agility;

    [SerializeField]
    private TMP_InputField m_objectName;

    [SerializeField]
    private TMP_InputField m_strength;

    [SerializeField]
    private TMP_InputField m_intelligence;

    [SerializeField]
    private TMP_InputField m_agility;


    public void UpdateName(TMP_InputField inputField)
    {
        objectName = inputField.text;
    }

    public void UpdateStrength(TMP_InputField inputField)
    {
        strength = int.Parse(inputField.text);
    }

    public void UpdateIntelligence(TMP_InputField inputField)
    {
        intelligence = int.Parse(inputField.text);
    }

    public void UpdateAgility(TMP_InputField inputField)
    {
        agility = int.Parse(inputField.text);
    }

    public void SaveGame()
    {
        SaveLoad.SaveGameData(this);
    }

    void Start()
    {
        SaveData data = SaveLoad.LoadGameData();

        if (data != null)
        {
            objectName = data.objectName;
            strength = data.strength;
            intelligence = data.intelligence;
            agility = data.agility;

            m_objectName.text = objectName;
            m_strength.text = strength.ToString();
            m_intelligence.text = intelligence.ToString();
            m_agility.text = agility.ToString();
        }
    }
}
