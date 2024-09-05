using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    [SerializeField] Camera _camera;
    [SerializeField] PlayerInput _input;
    public float yRotationSpeed, xRotationSpeed;

    private void RotateCamera()
    {
        Vector3 normalizedRotation = new Vector3
            (_input.rotation.x / _input.rotation.magnitude, _input.rotation.y / _input.rotation.magnitude, 0);

        _camera.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(1, 0, 0), _input.rotation.y * xRotationSpeed);
        _camera.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), _input.rotation.x * yRotationSpeed);
    }

    private void Update()
    {
        RotateCamera();
    }
}
