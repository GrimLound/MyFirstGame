using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReviev : MonoBehaviour
{
    [SerializeField] private float _Sensitivity = 100f;
    float _horizontal;
    float _vertical;
    public GameObject _PlayerRotate;

    private void FixedUpdate()
    {
        _horizontal += Input.GetAxis("Mouse X") * Time.fixedDeltaTime * _Sensitivity;
        _vertical += Input.GetAxis("Mouse Y") * Time.fixedDeltaTime * _Sensitivity;

        _vertical = Mathf.Clamp(_vertical, -90, 90);    
            _PlayerRotate.transform.rotation = Quaternion.Euler(0f, _horizontal, 0f);
    }

    void Update()
    {

        _horizontal += Input.GetAxis("Mouse X") * Time.fixedDeltaTime * _Sensitivity;
        _vertical += Input.GetAxis("Mouse Y") * Time.fixedDeltaTime * _Sensitivity;
        _vertical = Mathf.Clamp(_vertical, -90, 90);
            _PlayerRotate.transform.rotation = Quaternion.Euler(0f, _horizontal, 0f);
    }

  
}
