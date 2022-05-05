using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorOpened : MonoBehaviour
{
    [SerializeField] Transform _Door;

    private void OnTriggerEnter(Collider other)
    {
        _Door.Rotate(0, 90, 0);
        _Door.GetComponent<AudioSource>().Play();
        this.gameObject.SetActive(false);
    }

}
