using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Create new Item")]
[System.Serializable]

public class Items : ScriptableObject
{
    public int id;
    public string itemName;

    [TextArea(3, 3)] public string description;

    public enum Types
    {
        craftinMaterial,
        equipement,
        misecellaneous
    }

    public enum Rarity
    {
        common,
        uncommon,
        rare,
        epic,
        legendary,
    };

    public GameObject prefab;
    public Texture icon;

    public Types type;
    public Rarity rarity;
    public int maxStack;
    public float weight;
    public int baseValue;

}
