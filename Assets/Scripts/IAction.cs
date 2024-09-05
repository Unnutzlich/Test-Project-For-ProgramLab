using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public interface IAction
{
    public abstract void Interaction();
    public abstract string Name { get; }
}
