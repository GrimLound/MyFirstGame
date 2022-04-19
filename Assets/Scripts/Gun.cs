using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float _damage = 10f;
    public float _range = 50f;
    public float impactFource = 300f;

    public GameObject _gun;
    public AudioSource _shootSound;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        _shootSound.Play();
        RaycastHit hit;
        if(Physics.Raycast(_gun.transform.position, _gun.transform.forward, out hit, _range))
        {
            Debug.Log(hit.transform.name);
            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactFource);
            }
        }
    }

}
