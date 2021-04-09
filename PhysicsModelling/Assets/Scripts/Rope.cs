using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Rope : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Transform _pendulumTransform;
    [SerializeField] private Material _ropeMaterial;
    [SerializeField] private float _width;

    private LineRenderer _lineRenderer;

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        RenderRope(_width);
    }

    private void RenderRope(float width)
    {
        _lineRenderer.material = _ropeMaterial;
        _lineRenderer.SetPosition(0, _pendulumTransform.position);
        _lineRenderer.SetPosition(1, _targetTransform.position);
        _lineRenderer.startWidth = width;
        _lineRenderer.endWidth = width;

    }

    
}
