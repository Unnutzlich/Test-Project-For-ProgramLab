using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : IAction
{
    public void Interaction()
    {
        Debug.Log("Сменить цвет");
    }
    public string Name { get { return "Сменить цвет"; } }
}
