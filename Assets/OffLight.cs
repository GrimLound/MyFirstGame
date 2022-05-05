using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffLight : MonoBehaviour
{
    [SerializeField] AudioSource _Lump;
    [SerializeField] Light _light;

    private void OnTriggerEnter(Collider other)
    {
        _light.enabled = false;
        _Lump.Play();
        Destroy(this.gameObject);
    }
}
