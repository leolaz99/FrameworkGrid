using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GridGame))]
public class GridEditor : Editor 
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GridGame gridGame = (GridGame)target;

        if (GUILayout.Button("GENERATE MAP"))
        {
            gridGame.GenerateMap(gridGame.prefabFloor);
        }
    }
}
