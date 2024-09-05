using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Controller
{
    protected View _view;
    protected Model _model;

    public Controller(View view, Model model)
    {
        _view = view;
        _model = model;
    }

    public abstract void PreviousObject();
    public abstract void NextObject();
    public abstract void PreviousAction();
    public abstract void NextAction();
    public abstract void InvokeAction();
    public abstract void InstantiateObject();
}
