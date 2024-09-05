using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Model
{
    protected View _view;
    protected int _currentObjectIndex, _currentActionIndex;
    protected GameObject _currentObject;
    protected TestObjectData _objectData;
    protected IAction _currentAction;
    protected List<GameObject> _objects;
    protected List<IAction> _actions;

    public abstract int ObjectIndex { get; set; }
    public abstract int ActionIndex { get; set; }
    public abstract GameObject CurrentObject { get; set; }
    public abstract IAction CurrentAction { get; set; }
    public abstract TestObjectData ObjectData { get; set; }
    public abstract List<GameObject> Objects { get; set; }
    public abstract List<IAction> Actions { get; set; }

    public Model(View view)
    {
        _view = view; 
    }

    public Model(View view, List<GameObject> _objects) : this(view)
    {
        this._objects = _objects;
    }
}
