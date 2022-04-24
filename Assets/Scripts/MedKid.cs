using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKid : MonoBehaviour
{
    private float _healing = 25f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerInterface>()._playerHealth < 100)
        {
            other.GetComponent<PlayerInterface>().Healing(_healing);
            Destroy(this.gameObject);
        }  
    }
}
