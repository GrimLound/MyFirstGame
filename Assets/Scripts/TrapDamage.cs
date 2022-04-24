using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDamage : MonoBehaviour
{
    [SerializeField] AudioSource _trap;
    private float _damage = 15f;


    private void OnTriggerEnter(Collider other)
    {
        _trap.Play();
        other.GetComponent<PlayerInterface>().Damage(_damage);
    }
}
