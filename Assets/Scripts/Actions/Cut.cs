using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cut : IAction
{
    public void Interaction()
    {
        Debug.Log("������");
    }
    public string Name { get { return "������"; } }
}
