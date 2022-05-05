using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSteps : MonoBehaviour
{
    [SerializeField] GameObject _FootStepsEndPoint;
    public bool _Moved = false;
    void Update()
    {
        if (_Moved == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _FootStepsEndPoint.transform.position, Time.deltaTime);
        }
    }
}
