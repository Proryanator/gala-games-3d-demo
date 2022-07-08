using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayerAroundCenter : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 3f;

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}
