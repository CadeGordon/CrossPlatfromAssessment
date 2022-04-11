using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovemnetBehavior : MonoBehaviour
{
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

    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _mousePos = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));

            float xPos = _mousePos.x - _lastMousePos.x;

            _newPos.x = _localTransform.position.x + xPos;
            _newPos.y = _localTransform.position.y;
            _newPos.z = _localTransform.position.z;

            _localTransform.position = _newPos + _localTransform.forward * _speed * Time.deltaTime;

            _lastMousePos = _mousePos;
        }
    }
}
