using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeFlashLight : MonoBehaviour
{
    [SerializeField] Light _PlayerFlashLight;
    [SerializeField] GameObject _FlashLight;
    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.E))
        {                      
            _PlayerFlashLight.GetComponent<PlayerFlashLight>().TakeFlashLight();
            Destroy(_FlashLight);
        }
    }
}
