using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInterface : MonoBehaviour
{
    private float _MaxHealth = 100;
    public float _playerHealth;  
    [SerializeField] Text _healthNum;
    [SerializeField] Text _healthText;
    [SerializeField] AudioSource _Heal;


    private void Start()
    {
        _playerHealth = _MaxHealth;
    }
    private void Update()
    {
        if(_playerHealth <= 100 && _playerHealth >= 70)
        {
            _healthNum.color = Color.green;
            _healthText.color = Color.green;
        }
        else if (_playerHealth <= 70 && _playerHealth >= 30)
        {
            _healthNum.color = Color.yellow;
            _healthText.color = Color.yellow;
        }
        else if (_playerHealth <= 30 && _playerHealth >= 0)
        {
            _healthNum.color = Color.red;
            _healthText.color = Color.red;
        }
    }
    public void Damage(float damage)
    {
        _playerHealth -= damage;
        _healthNum.text = $"{_playerHealth}";
        if(_playerHealth <= 0)
        {
            _healthNum.text = $"{0}";
        }
    }
    public void Healing(float healing)
    {
        _Heal.Play();
        _playerHealth += healing;
        _healthNum.text = $"{_playerHealth}";
        if (_playerHealth >= 100)
        {
            _playerHealth = 100;
            _healthNum.text = $"{100}";
        }
    }

    void Die()
    {
        if (_playerHealth <= 0)
        {
            Debug.Log("Game Over!");
        }
    }

}
