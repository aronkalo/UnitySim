using UnityEngine;

[RequireComponent(typeof(Camera))]
public class ThirdPersonCameraMovement : MonoBehaviour
{
    private const float X_AXIS_MIN = 0.0f;
    private const float X_AXIS_MAX = 50.0f;
    private const string MOUSE_X = "Mouse X";
    private const string MOUSE_Y = "Mouse Y";

    private float _xAxis = 0.0f;
    private float _yAxis = 0.0f;
    private Vector3 _targetOffset;

    [SerializeField()]
    private float _distance = 10.0f;

    [SerializeField()]
    private float _xAxisSensitvity = 8.0f;

    [SerializeField()]
    private float _yAxisSensitivity = 3.0f;

    [SerializeField()]
    private Transform _targetTransform;

    private void Start()
    {
        _targetOffset = new Vector3(0, 0, -_distance);
        if (_targetTransform is null)
            throw new UnassignedReferenceException(nameof(_targetTransform));
    }

    // Update is called once per frame
    private void Update()
    {
        GetMouseAxis();
        var positionDelta = Quaternion.Euler(_xAxis, _yAxis, 0) * _targetOffset;
        this.transform.position = _targetTransform.position + ( positionDelta );
        this.transform.LookAt(_targetTransform.position);
    }

    private void GetMouseAxis()
    {
        _xAxis += Input.GetAxis(MOUSE_X);
        _yAxis += Input.GetAxis(MOUSE_Y);
        _xAxis = Mathf.Clamp(_xAxis, X_AXIS_MIN, X_AXIS_MAX);
    }
}

