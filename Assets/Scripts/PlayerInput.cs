using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public Vector2 rotation;

    public void OnRotateCamera(InputValue value)
    {
        rotation = value.Get<Vector2>();
    }
}
