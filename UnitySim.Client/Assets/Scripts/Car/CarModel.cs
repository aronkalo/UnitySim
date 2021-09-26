using Assets.Scripts.Car;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarModel : MonoBehaviour
{
    private CarRegulator _regulator;

    [SerializeField()]
    private IEnumerable<AxleInfo> _axleInfos;

    [SerializeField()]
    private MotorConfiguration _motorConfiguration;
    
    void Start()
    {
        if (_axleInfos is null)
            throw new UnassignedReferenceException(nameof(_axleInfos));

        this._motorConfiguration.BodyWork = this.gameObject.GetComponent<Rigidbody>();
        this._regulator = new CarRegulator(this._axleInfos, this._motorConfiguration);
    }

    public void FixedUpdate()
    {
        
        //_acceleration = (_maximalMotorTorque * _scaler / _bodywork.mass);
        //if (gasIntensity == 0)
        //{
        //    _torque = _torque <= 0 ? 0 : _torque - _acceleration;
        //}
        //else
        //{
        //    float nextTorque = _torque + _acceleration * gasIntensity;
        //    _torque = nextTorque <= _maximalMotorTorque ? (nextTorque >= -_maximalMotorTorque ? nextTorque : -_maximalMotorTorque): _maximalMotorTorque;
        //}
        

        //foreach (AxleInfo axleInfo in _axleInfos)
        //{
        //    if (axleInfo.Steering)
        //    {
        //        axleInfo.LeftWheel.steerAngle = steering;
        //        axleInfo.RightWheel.steerAngle = steering;
        //    }
        //    if (axleInfo.Motorized)
        //    {
        //        axleInfo.LeftWheel.motorTorque = _torque;
        //        axleInfo.RightWheel.motorTorque = _torque;
        //    }
        //}
    }
}

[System.Serializable]
public class AxleInfo
{
    public WheelCollider LeftWheel;
    public WheelCollider RightWheel;
    public bool Motorized;
    public bool Steering;
}

[System.Serializable]
public class MotorConfiguration
{
    public float MaximalMotorTorque;

    public float MaximalSteeringAngle;

    public float Scaler;

    public Rigidbody BodyWork;
}