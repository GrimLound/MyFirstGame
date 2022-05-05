using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToOpenDoor : MonoBehaviour
{
    [SerializeField] GameObject _Door;
    bool _TurnOn = false;

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.F) && _TurnOn == false)
        {
            GetComponent<AudioSource>().Play();
            AudioSource opendoor = _Door.GetComponent<AudioSource>();
            opendoor.Play();
            _Door.transform.Rotate(0, -90, 0);
            _TurnOn = true;
        }
    }

}
