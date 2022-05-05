using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] GameObject _Enemy;
    public GameObject _Parent;

    private void Start()
    {
        Instantiate(_Enemy, _Parent.transform.position, transform.rotation, _Parent.transform);
    }
}
