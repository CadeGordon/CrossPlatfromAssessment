using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehavior : MonoBehaviour
{
   private string _playerTag;
    [SerializeField]
    private float _damage;
    [SerializeField]
    private float _lifeTime;
    private bool _destroyOnHit;
    private float _currentLifeTime;
    private Rigidbody _rigidBody;
    [SerializeField]
    private Transform _target;

    public Transform Target
    {
        get { return _target; }
        set { _target = value; }
    }

    public string OwnerTag
    {
        get { return _playerTag; }
        set { _playerTag = value; }
    }

    public Rigidbody Rigidbody
    {
        get { return _rigidBody; }
    }

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == Target)
            return;

        HealthBehavior otherHeatlh = other.GetComponent<HealthBehavior>();

        if (!otherHeatlh)
            return;

        otherHeatlh.TakeDamage(_damage);

        if (_destroyOnHit)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if (_currentLifeTime >= _lifeTime)
            Destroy(gameObject);
    }
}
