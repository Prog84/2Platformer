using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _template;
    [SerializeField] private Transform[] _spawnPoints;
    private void Start()
    {
        foreach (var point in _spawnPoints)
        {
            Instantiate(_template, point.position, Quaternion.identity);
        }
    }
}
