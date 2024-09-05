using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] TestObjectData _objectData;
    [SerializeField] List<GameObject> _subObjects;

    public TestObjectData ObjectData {
        get { return _objectData; } 
    }
}
