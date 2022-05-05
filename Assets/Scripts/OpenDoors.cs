using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoors : MonoBehaviour
{
    [SerializeField] Transform _Door;

    private void OnTriggerEnter(Collider other)
    {
            _Door.Rotate(0, -90, 0);      
    }
    private void OnTriggerExit(Collider other)
    {
            _Door.Rotate(0, 90, 0);        
    }
}
