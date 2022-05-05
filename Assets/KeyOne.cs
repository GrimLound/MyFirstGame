using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOne : MonoBehaviour
{
    [SerializeField] AudioSource _Cry;
    [SerializeField] GameObject _Player;
    [SerializeField] GameObject _Key;
    [SerializeField] GameObject _FootSteps;
    [SerializeField] GameObject _door;
    [SerializeField] GameObject _doorTwo;

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKey(KeyCode.F))
        {
            _Cry.Stop();
            _doorTwo.GetComponent<DoorOneTrigger>()._Opened = true;
            _door.transform.Rotate(0, 27, 0);
            _door.GetComponent<AudioSource>().Play();
            _Player.GetComponent<PlayerInterface>().TakeKey();
            _FootSteps.GetComponent<AudioSource>().Play();
            _FootSteps.GetComponent<FoodStepsOne>()._Move = true;
            Destroy(_Key);
        }        
    }
}
