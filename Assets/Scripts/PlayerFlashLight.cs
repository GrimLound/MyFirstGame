using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlashLight : MonoBehaviour
{

    public Light _FlashLight;
    public void Awake()
    {
        _FlashLight.GetComponent<Light>();
    }
    void Update()
    {      
            if (Input.GetKeyUp(KeyCode.E))
            {
            _FlashLight.enabled = !_FlashLight.enabled;               
            }      
    }
}
