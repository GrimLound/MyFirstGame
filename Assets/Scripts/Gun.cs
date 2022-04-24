using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public float _damage = 8f;
    public float _range = 50f;
    public float impactFource = 150f;
    private float MaxAmmoInMagazine = 8;
    private float _ammo = 8;
    private float _ammoCount = 15;

    public GameObject _gun;
    public AudioSource _shootSound;
    public AudioSource _noAmmo;
    public AudioSource _reload;
    public AudioSource _NoAmmoToReload;
    [SerializeField] Text _ammoText;
    [SerializeField] Text _ammoCountText;

    private void Start()
    {
        _ammo = MaxAmmoInMagazine;
        _ammoCount = 15;
        _ammoText.text = $"{_ammo}";
        _ammoCountText.text = $"{_ammoCount}";
    }
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        if(Input.GetKeyDown(KeyCode.R) && _ammo < 8)
        {
            Reload();
        }
    }
    void Reload()
    {
        if (_ammoCount > 0)
        {
            _reload.Play();
            if (_ammoCount >= MaxAmmoInMagazine - _ammo)
            {
                _ammoCount -= (MaxAmmoInMagazine - _ammo);
                _ammo += (MaxAmmoInMagazine - _ammo);
                _ammoCountText.text = $"{_ammoCount}";
                _ammoText.text = $"{_ammo}";
            }
            if(_ammoCount < MaxAmmoInMagazine - _ammo)
            {                
                _ammo += _ammoCount;
                _ammoCount = 0;
                _ammoCountText.text = $"{0}";
                _ammoText.text = $"{_ammo}";
            }
            if (_ammo > 2)
            {
                _ammoText.color = Color.green;
            }
            else if (_ammo <= 2)
            {
                _ammoText.color = Color.red;
            }
        }
        else
        {
            _NoAmmoToReload.Play();
        }
    }
    public void GetAmmo(float ammo)
    {
        _ammoCount += ammo;
        _ammoCountText.text = $"{_ammoCount}";
    }
    void Shoot()
    {
        if(_ammo > 0)
        {
            _shootSound.Play();
            _ammo -= 1;
            _ammoText.text = $"{_ammo}";
            RaycastHit hit;
            if (Physics.Raycast(_gun.transform.position, _gun.transform.forward, out hit, _range))
            {
                if(hit.transform.tag == "Enemy")
                {
                    Debug.Log(hit.transform.name);
                    hit.transform.GetComponent<EnemyHealth>().Damage(_damage);
                }
                    if (hit.rigidbody != null)
                    {
                        hit.rigidbody.AddForce(-hit.normal * impactFource);
                    }     
            }
        }
        else
        {
            _noAmmo.Play();
        }      
        if (_ammo > 2)
        {
            _ammoText.color = Color.green;
        }
        else if (_ammo <= 2)
        {
            _ammoText.color = Color.red;
        }
    }

}
