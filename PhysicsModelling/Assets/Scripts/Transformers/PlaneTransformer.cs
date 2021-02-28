﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTransformer : MechanicalTransformer
{
    [SerializeField] private float _angle;
    [SerializeField] private float _length;
    [SerializeField] private float _height;

    public float Angle => _angle;
    public float Length => _length;

    private void Awake()
    {
        _length = Mathf.Abs(transform.localScale.z);
        _angle = 0;
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

    public void SetLength(float lenght)
    {
        _transform.localScale = new Vector3(transform.localScale.x, _transform.localScale.y, lenght);
        _length = lenght;
    }

    public void SetWidth(float width)
    {
        _transform.localScale = new Vector3(width, transform.localScale.y, transform.localScale.z);
    }
}
