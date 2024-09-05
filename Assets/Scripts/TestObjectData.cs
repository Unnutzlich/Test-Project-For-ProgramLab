using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectData", menuName = "TestProject/Object")]
public class TestObjectData : ScriptableObject
{
    [SerializeField] string _name, _description;
    [SerializeReference, ImplementationPicker] List<IAction> _algorithms;
    [Header("Add algorithm to list")]
    [SerializeReference, ImplementationPicker] IAction _algorithm;

    public IAction Algorithm { 
        get { return _algorithm; } set { _algorithm = value; } 
    }
    public List<IAction> Algorithms { 
        get { return _algorithms; } 
        set { _algorithms = value; } 
    }
    public string Name
    {
        get { return _name; }
    }
    public string Description
    {
        get { return _description; }
    }

    public TestObjectData() {
        _name = _description = "";
        _algorithms = new List<IAction>();
        _algorithms.Add(new Cut());
        _algorithms.Add(new Decompose());
    }

    [ContextMenu("Debug")]
    public void Debug1()
    {
        Debug.Log(string.Join(", ", System.Reflection.Assembly.GetAssembly(this.GetType()).GetTypes()
    .Where(t => t.IsClass && !(t.GetInterface("IAction") is null)).Select(x => x.ToString())));
    }
}
