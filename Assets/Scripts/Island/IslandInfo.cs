using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CreateAssetMenu(menuName = "IslandInfo")]
public class IslandInfo : ScriptableObject
{
    public IslandType type;
    public int id;

    [ContextMenu("Name")]
    public void SetName()
    {
        Debug.Log("Sup");
        name = type.ToString().Substring(0, 1).ToLower() + id.ToString("000");
        string path = AssetDatabase.GetAssetPath(GetInstanceID());
        AssetDatabase.RenameAsset(path, name);
        AssetDatabase.SaveAssets();
    }
}

public enum IslandType
{
    NONE,
    ISLAND,
    SHOP,
    CAVE,
    REST,
    BOSS
}

public enum PoolType
{
    NONE,
    CHEST,
    SHOP,
    PET,
    CAVE,
    BOSS
}