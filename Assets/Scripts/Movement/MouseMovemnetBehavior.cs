using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovemnetBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _mouseMovement;
    [SerializeField]
    public float _speed;

    void Awake()
    {
        _mouseMovement = GetComponent<PlayerMovementBehavior>();
    }

    void Update()
    {
        //if left mouse button is pressed..
        if (Input.GetMouseButton(0))
        {
            //..move the player in the direction of mouse direction
            _mouseMovement.MoveDirection = new Vector3(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")).normalized;

        }
    }
}
