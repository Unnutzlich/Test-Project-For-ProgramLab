using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Codice.CM.Common;

[CustomEditor(typeof(TestObjectData))]
public class ObjectDataEditor : Editor
{
    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();

        if(GUILayout.Button("Add algorithm"))
        {
            AddButton();
        }
    }
    void AddButton()
    {
        TestObjectData _data = (TestObjectData)target;

        _data.Algorithms.Add(_data.Algorithm);
    }
}
