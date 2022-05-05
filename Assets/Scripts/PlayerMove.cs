using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Camera _CameraRotate;
    [SerializeField] GameObject _PlayerRotate;
    [SerializeField] Light _FlashLight;
    Rigidbody _RB;
    [SerializeField] float Speed = 80f;
    [SerializeField] float _Sensitivity = 250f;
    float smoothtime = 0.1f;
    float _xRot;
    float _yRot;
    float _xRotCurrent;
    float _yRotCurrent;
    float _xCurrentVelosity;
    float _yCurrentVelosity;

    public void Awake()
    {
        _RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float v = Input.GetAxis("Vertical") * Speed * Time.fixedDeltaTime;
        float h = Input.GetAxis("Horizontal") * Speed * Time.fixedDeltaTime;
        _RB.velocity = transform.TransformDirection(h, _RB.velocity.y, v);

        _xRot += Input.GetAxis("Mouse X") * Time.fixedDeltaTime * _Sensitivity;
        _yRot += Input.GetAxis("Mouse Y") * Time.fixedDeltaTime * _Sensitivity;
        _yRot = Mathf.Clamp(_yRot, -90, 90);
        
        _xRotCurrent = Mathf.SmoothDamp(_xRotCurrent, _xRot, ref _xCurrentVelosity, smoothtime);
        _yRotCurrent = Mathf.SmoothDamp(_yRotCurrent, _yRot, ref _yCurrentVelosity, smoothtime);

        _FlashLight.transform.rotation = Quaternion.Euler(-_yRot, _xRot, 0f);
        _CameraRotate.transform.rotation = Quaternion.Euler(-_yRot, _xRot, 0f);
        _PlayerRotate.transform.rotation = Quaternion.Euler(0f, _xRot, 0f);
    }
   
}
