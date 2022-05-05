using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] Light _light;
    [SerializeField] AudioSource _Cry;
    [SerializeField] GameObject _StepsToPlayer;


    private void OnTriggerEnter(Collider other)
    {
        _Cry.Stop();
        _light.enabled = false;
        _StepsToPlayer.GetComponent<AudioSource>().Play();
        _StepsToPlayer.GetComponent<EndSteps>()._Moved = true;
    }
}
