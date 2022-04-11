using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovemnetBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _mouseMovement;

    private Rigidbody _rigidbody;
    [SerializeField]
    private Camera _camera;
    private Vector3 _lastMousePos;
    private Vector3 _mousePos;
    private Vector3 _newPos;
    private Transform _transform;
    private Transform _localTransform;
    [SerializeField]
    public float _speed;

    void Awake()
    {
        _mouseMovement = GetComponent<PlayerMovementBehavior>();

        //_transform = GetComponent<Transform>();
        //_localTransform = GetComponent<Transform>();
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        _mousePos = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));

    //        float xPos = _mousePos.x - _lastMousePos.x;

    //        _newPos.x = _localTransform.position.x - xPos;
    //        _newPos.y = _localTransform.position.y;
    //        _newPos.z = 0;

    //        _localTransform.position = _newPos + _localTransform.forward * _speed * Time.deltaTime;

    //        _lastMousePos = _mousePos;
    //    }
    //}

    //private void FixedUpdate()
    //{
    //    Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit hitInfo;

    //    //If the ray hits an object
    //    if (Physics.Raycast(ray, out hitInfo))
    //    {
    //        //do mouse stuff
    //    }
    //}

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
