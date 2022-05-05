using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepsTwo : MonoBehaviour
{
    [SerializeField] GameObject _FootStepsEndPoint;
    public bool _Move = false;
    void Update()
    {
        if (_Move == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _FootStepsEndPoint.transform.position, Time.deltaTime);
        }
    }
}
