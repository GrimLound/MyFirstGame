using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    private float _MaxEnemyHealth = 30f;
    private float _enemyHealth;

    private void Start()
    {      
        _enemyHealth = _MaxEnemyHealth;
    }

    private void Update()
    {
        Die();
    }
    public void Damage(float damage)
    {
        _enemyHealth -= damage;
    }
    
    void Die()
    {
        if (_enemyHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
