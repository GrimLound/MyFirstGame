using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCloseDoor : MonoBehaviour
{
    [SerializeField] Transform _door;
    [SerializeField] AudioSource _close;
    [SerializeField] AudioSource _Cry;

    private void OnTriggerEnter(Collider other)
    {
        _door.transform.Rotate(0, 90, 0);
        _close.Play();
        _Cry.Play();
    }
}
