using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OoenDoorTwoSR : MonoBehaviour
{
    [SerializeField] GameObject _door;

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.F))
        {
            _door.transform.Rotate(0, -90, 0);
            _door.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
        }
    }
}
