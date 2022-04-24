using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoors : MonoBehaviour
{
    [SerializeField] Text _InputE;
    [SerializeField] Transform _Door;

    private void Start()
    {
        _InputE.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        _InputE.enabled = true;
        Debug.Log("You Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        _InputE.enabled = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            _InputE.enabled = false;
            _Door.Rotate(0, -90, 0);
            Destroy(this.gameObject);
        }
    }
}
