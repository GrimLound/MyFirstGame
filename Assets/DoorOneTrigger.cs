using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOneTrigger : MonoBehaviour
{
    [SerializeField] AudioSource _Close;
    [SerializeField] GameObject _door;
    public bool _Opened = false;

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.F) && _Opened == false)
        {
            _Close.Play();
        }
        else if(Input.GetKey(KeyCode.F) && _Opened == true)
        {
            _door.GetComponent<AudioSource>().Play();
            _door.transform.Rotate(0, -90, 0);
            Destroy(this.gameObject);
        }
    }
}
