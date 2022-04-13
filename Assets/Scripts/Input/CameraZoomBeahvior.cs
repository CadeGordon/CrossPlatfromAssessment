using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraZoomBeahvior : MonoBehaviour
{
    private Camera _camera;
    [SerializeField]
    private Vector2 _referenceAspectRatio;
    private Vector3 _startPos;
    private float _refRatio;
    [SerializeField]
    private Vector3 _zoomScale = Vector3.one;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        _refRatio = _referenceAspectRatio.x / _referenceAspectRatio.y;
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (_referenceAspectRatio.x <= 0 || _referenceAspectRatio.y <= 0)
            return;

        double ratio = _refRatio / _camera.aspect;
        ratio = Math.Round(ratio, 4);

        Vector3 scaledPosition = Vector3.Scale(_startPos * (float)ratio, _zoomScale);

        transform.position = scaledPosition;

    }
}
