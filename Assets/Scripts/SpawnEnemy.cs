using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject _enemy;
    public GameObject _Parent;   
    void Start()
    {                 
            Instantiate(_enemy, _Parent.transform.position, transform.rotation);       
    }
}
