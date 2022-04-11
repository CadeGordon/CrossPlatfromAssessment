using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawnBehavior : MonoBehaviour
{
    [SerializeField]
    private RockMovementBehavior _rock;

    [SerializeField]
    private Transform _rockTarget;

    [SerializeField]
    private float _timeAlive;

    [SerializeField]
    private float _spawnTimer = 5.0f;
    private float _timer = 0.0f;
    [SerializeField]
    private float _enemySpawnCount;

    private void Update()
    {
        if (_timer >= _spawnTimer)
        {
            RockMovementBehavior spawnedRock = Instantiate(_rock, transform.position, transform.rotation);
            spawnedRock.Target = _rockTarget;
            _timer = 0.0f;
        }
        _timer += Time.deltaTime;

       
        
    }
}
