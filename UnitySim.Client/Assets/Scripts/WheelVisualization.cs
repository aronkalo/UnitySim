using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(WheelCollider))]
public class WheelVisualization : MonoBehaviour
{
    private WheelCollider _collider;
    private Vector3Int _rotationVector = new Vector3Int(0, 0, 90);

    [SerializeField()]
    private GameObject _visualWheel;

    // Start is called before the first frame update
    void Start()
    {
        _collider = this.gameObject.GetComponent<WheelCollider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _collider.GetWorldPose(out Vector3 position, out Quaternion rotation);
        rotation = rotation * Quaternion.Euler(_rotationVector);
        _visualWheel.transform.position = position;
        _visualWheel.transform.rotation = rotation;
    }
}
