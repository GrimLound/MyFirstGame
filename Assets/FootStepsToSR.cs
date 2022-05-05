using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepsToSR : MonoBehaviour
{
    [SerializeField] GameObject _footsteps;
    [SerializeField] GameObject _HorrorSound;

    private void OnTriggerEnter(Collider other)
    {
        _footsteps.GetComponent<FootStepsTwo>()._Move = true;
        _footsteps.GetComponent<AudioSource>().Play();
        _HorrorSound.GetComponent<AudioSource>().Play();
        Destroy(this.gameObject);
    }

}
