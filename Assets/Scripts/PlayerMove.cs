using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject _PlayerRotate;
    public GameObject _Gun;
    Rigidbody _RB;
    [SerializeField] float Speed = 80f;
    [SerializeField] float BoostSpeed = 120f;
    [SerializeField] float _Sensitivity = 250f; 
    float _Horizontal;

    public void Awake()
    {
        _RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _Horizontal += Input.GetAxis("Mouse X") * Time.fixedDeltaTime * _Sensitivity;
        _PlayerRotate.transform.rotation = Quaternion.Euler(0f, _Horizontal, 0f);
        _Gun.transform.rotation = Quaternion.Euler(0f, _Horizontal, 0f);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            float v = Input.GetAxis("Vertical") * BoostSpeed * Time.fixedDeltaTime;
            float h = Input.GetAxis("Horizontal") * BoostSpeed * Time.fixedDeltaTime;
            _RB.velocity = transform.TransformDirection(h, _RB.velocity.y, v);
        }
        else
        {
            float v = Input.GetAxis("Vertical") * Speed * Time.fixedDeltaTime;
            float h = Input.GetAxis("Horizontal") * Speed * Time.fixedDeltaTime;
            _RB.velocity = transform.TransformDirection(h, _RB.velocity.y, v);
        }
        _Horizontal += Input.GetAxis("Mouse X") * Time.fixedDeltaTime * _Sensitivity;
        _PlayerRotate.transform.rotation = Quaternion.Euler(0f, _Horizontal, 0f);
    }
}
