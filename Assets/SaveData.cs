using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    [SerializeField] private PlayerData _PlayerData = new PlayerData();
    public GameObject nameField;
    public GameObject raceField;
    public void GetName()
    {
        _PlayerData.char_name = nameField.GetComponent<Text>().text;
        _PlayerData.char_race = raceField.GetComponent<Text>().text;
        SaveIntoJson();
        
    }
    public void SaveIntoJson()
    {
        string name = JsonUtility.ToJson(_PlayerData);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/PlayerData.json", name);
        Debug.Log(Application.persistentDataPath);
    }
}

[System.Serializable]
public class PlayerData
{
    public string char_name;
    public string char_race;
    public string char_class;
    public string char_alignment;
    public int char_xp;
    public int char_hp;
    public int char_armor;
    public int char_speed;
    public List<Item> char_item = new List<Item>();
    public float ability_str;
    public float ability_dex;
    public float ability_con;
    public float ability_int;
    public float ability_wis;
    public float ability_cha;
}

[System.Serializable]
public class Item
{
    public string name;
}