using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMovementBehavior : MovementBehavior
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _damage;
    

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }

    public Transform Target
    {
        get { return _target; }
        set { _target = value; }
    }

    public override void Update()
    {
        Vector3 direction = _target.position - transform.position;
        Velocity = direction.normalized * Speed;

        base.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _target)
        {
            HealthBehavior playerHealth = other.GetComponent<HealthBehavior>();
            if (playerHealth)
                playerHealth.TakeDamage(_damage);
            
            Destroy(gameObject);
        }
    }

   

}
