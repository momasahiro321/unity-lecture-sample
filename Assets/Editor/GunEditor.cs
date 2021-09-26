using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Gun))] //Gunスクリプトのインスペクタの表示を拡張
public class GunEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("Reset Rotation")){ //ボタンを表示
            (target as Gun).transform.rotation = Quaternion.identity;
        }
    }
}