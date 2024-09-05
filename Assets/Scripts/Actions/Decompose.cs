using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decompose : IAction
{
    public void Interaction()
    {
        Debug.Log("Декомпозиция");
    }
    public string Name { get { return "Декомпозиция"; } }
}
