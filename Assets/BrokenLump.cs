using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenLump : MonoBehaviour
{
    [SerializeField] Light _Pointlight;
    [SerializeField] Light _Spotlight;
    [SerializeField] AudioSource _Broke;
    public void TurnOffLight()
    {
        _Pointlight.enabled = false;
        _Spotlight.enabled = false;
        _Broke.Play();
    }

}
