using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : IAction
{
    public void Interaction()
    {
        Debug.Log("������� ����");
    }
    public string Name { get { return "������� ����"; } }
}
