using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlashLight : MonoBehaviour
{
    public bool HaveFlashlight = false;
    public Light _FlashLight;
    [SerializeField] AudioSource _TurnFlashlight;
    public void Awake()
    {
        _FlashLight.GetComponent<Light>();
    }
    private void Start()
    {
        _FlashLight.enabled = false;
    }
    void Update()
    {      
            if (Input.GetKeyUp(KeyCode.E) && HaveFlashlight == true)
            {
            _TurnFlashlight.Play();
            _FlashLight.enabled = !_FlashLight.enabled;               
            }      
    }
    public void TakeFlashLight()
    {
        HaveFlashlight = true;
    }
}
