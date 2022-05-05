using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    [SerializeField] GameObject _door;   


    private void OnTriggerEnter(Collider other)
    {
        _door.transform.Rotate(0, 90, 0);
        _door.GetComponent<AudioSource>().Play();
        this.gameObject.SetActive(false);
    }
}
