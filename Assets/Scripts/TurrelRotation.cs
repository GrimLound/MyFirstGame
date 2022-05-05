using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrelRotation : MonoBehaviour
{

    [SerializeField] Transform _TurrelHead;
    [SerializeField] Transform _Target;
    float _RotationSpeed = 1f;
 
    private void Update()
    {       
        var RotDirection = _TurrelHead.position - _Target.position;
        _TurrelHead.forward = RotDirection;
    }
}
