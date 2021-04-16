using System;
using System.Collections;
using System.Collections.Generic;
using InputFields;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RopeTransformer : MechanicalTransformer, ILengtheningTransformer
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Transform _pendulumTransform;
    [SerializeField] private Material _ropeMaterial;
    [SerializeField] private float _width;

    private HingeJoint _hingeJoint;
    private LineRenderer _lineRenderer;

    protected override void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
        _lineRenderer = GetComponent<LineRenderer>();
        _pendulumTransform = this.transform;
        
    }

    private void Update()
    {
        RenderRope(_width);
    }

    public void SetLength(float length)
    {
        _hingeJoint.autoConfigureConnectedAnchor = false;
        _hingeJoint.anchor = new Vector3(0, length, 0);
    }

    public void SetPositionX(float x)
    {
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
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
