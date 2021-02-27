using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTransformer : MechanicalTransformer
{
    protected override void Start()
    {
        base.Start();
    }

    public override void SetHeight(float height)
    {
        _transform.localScale = new Vector3(_transform.localScale.x, height, _transform.localScale.z);
    }

    public void SetAngle(float degreeAngle)
    {
        _transform.rotation = Quaternion.Euler(degreeAngle, _transform.rotation.y, _transform.rotation.z);
    }
}
