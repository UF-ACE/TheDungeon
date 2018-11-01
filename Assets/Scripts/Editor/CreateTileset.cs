using UnityEngine;
using System.Collections;
using UnityEditor;

public class CreateTileset
{
    [MenuItem("Assets/Create/TheDungeon/Tileset")]
    public static void CreateMyAsset()
    {
        Tileset asset = ScriptableObject.CreateInstance<Tileset>();

        AssetDatabase.CreateAsset(asset, "Assets/Scripts/Levels/Tilesets/Tileset.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}