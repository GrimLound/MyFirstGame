using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBrokeLump : MonoBehaviour
{
    [SerializeField] GameObject _Lamp;

    private void OnTriggerEnter(Collider other)
    {
        _Lamp.GetComponent<BrokenLump>().TurnOffLight();
        this.gameObject.SetActive(false);
    }

}
