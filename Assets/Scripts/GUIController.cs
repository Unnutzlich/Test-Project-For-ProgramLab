using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GUIController : Controller
{

    public GUIController(View view, Model model) : base(view, model) 
    {
        InstantiateObject();
    }

    public override void PreviousObject()
    {
        _model.ObjectIndex = _model.ObjectIndex != 0 ?
            --_model.ObjectIndex : _model.Objects.Count - 1;
        InstantiateObject();
        Debug.Log($"Object index: {_model.ObjectIndex}");
    }
    public override void NextObject()
    {
        _model.ObjectIndex = _model.ObjectIndex != _model.Objects.Count - 1 ?
            ++_model.ObjectIndex : 0;
        InstantiateObject();
        Debug.Log($"Object index: {_model.ObjectIndex}");
    }
    public override void PreviousAction()
    {
        _model.CurrentAction = _model.Actions
            [
            _model.ActionIndex = _model.ActionIndex != 0 ?
            --_model.ActionIndex : _model.Actions.Count - 1
            ];
        _view.DisplayAction(_model.CurrentAction.Name);
        Debug.Log($"Action index: {_model.ActionIndex}");
    }
    public override void NextAction()
    {
        _model.CurrentAction = _model.Actions
            [
            _model.ActionIndex = _model.ActionIndex != _model.Actions.Count - 1 ?
            ++_model.ActionIndex : 0
            ];
        _view.DisplayAction(_model.CurrentAction.Name);
        Debug.Log($"Action index: {_model.ActionIndex}");
    }
    public override void InvokeAction()
    {
        _model.CurrentAction.Interaction();
    }
    public override void InstantiateObject()
    {
        if(!(_model.CurrentObject is null))
        {
            Object.Destroy(_model.CurrentObject);
        }

        _model.CurrentObject = Object.Instantiate(
            _model.Objects[_model.ObjectIndex],
            new Vector3(0,0,0)
            , new Quaternion());

        Object obj = _model.CurrentObject.GetComponentInChildren<Object>();
        _view.DisplayName(_model.ObjectData.Name);
        _view.DisplayDescription(_model.ObjectData.Description);
        _view.DisplayAction(_model.CurrentAction.Name);
    }
}
