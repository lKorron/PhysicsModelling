using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTransformer : MechanicalTransformer
{
    [SerializeField] private float _angle;
    [SerializeField] private float _length;
    [SerializeField] private float _height;
    [SerializeField] private BoxCollider _boxCollider;

    public float Angle => _angle;
    public float Length => _length;

    private void Awake()
    {
        _length = Mathf.Abs(transform.localScale.z);
        _angle = 0;
    }

    protected override void Start()
    {
        base.Start();
        if (_boxCollider == null)
            _boxCollider = GetComponentInChildren<BoxCollider>();
        SetFriction(0f);
    }

    public override void SetHeight(float height)
    {
        _transform.localScale = new Vector3(_transform.localScale.x, height, _transform.localScale.z);
    }

    public void SetAngle(float degreeAngle)
    {
        _transform.rotation = Quaternion.Euler(degreeAngle, _transform.rotation.y, _transform.rotation.z);
        _angle = degreeAngle;
    }

    public void SetLength(float length)
    {
        _transform.localScale = new Vector3(transform.localScale.x, _transform.localScale.y, length);
        _length = length;
    }

    public void SetWidth(float width)
    {
        _transform.localScale = new Vector3(width, transform.localScale.y, transform.localScale.z);
    }

    public void SetFriction(float friction)
    {
        _boxCollider.material.staticFriction = friction;
        _boxCollider.material.dynamicFriction = friction;
    }
}
