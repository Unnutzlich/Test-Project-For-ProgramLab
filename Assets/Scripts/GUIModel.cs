using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIModel : Model
{
    public GUIModel(View view) : base(view) { }
    public GUIModel(View view, List<GameObject> _objects) : base(view, _objects) { }

    public override int ObjectIndex
    {
        get { return _currentObjectIndex; }
        set { _currentObjectIndex = value; }
    }
    public override int ActionIndex
    {
        get { return _currentActionIndex; }
        set { _currentActionIndex = value; }
    }
    public override GameObject CurrentObject
    {
        get { return _currentObject; }
        set
        {
            _currentObject = value;
            ObjectData = _currentObject.GetComponentInChildren<Object>().ObjectData;
            Actions = ObjectData.Algorithms;
            CurrentAction = Actions[0];
            ActionIndex = 0;
        }
    }
    public override IAction CurrentAction
    {
        get { return _currentAction; }
        set { _currentAction = value; }
    }
    public override TestObjectData ObjectData
    {
        get { return _objectData; }
        set { _objectData = value; }
    }
    public override List<GameObject> Objects
    {
        get { return _objects; }
        set { _objects = value; }
    }
    public override List<IAction> Actions
    {
        get { return _actions; }
        set { _actions = value; }
    }
}
