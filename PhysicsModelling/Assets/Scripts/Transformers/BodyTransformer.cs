using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BodyTransformer : MechanicalTransformer
{
    private Rigidbody _rigidbody;

    protected override void Start()
    {
        base.Start();
        _rigidbody = GetComponent<Rigidbody>();
    }

    public override void SetHeight(string stringHeight)
    {
        if (float.TryParse(stringHeight, out float height))
            SetHeight(height);
    }

    public void SetMass(float mass)
    {
        _rigidbody.mass = mass;
        var scaler = Mathf.Pow(mass, 1f / 3f);
        _transform.localScale = Vector3.one * scaler;
    }

    public void SetMass(string stringMass)
    {
        if (float.TryParse(stringMass, out float mass))
            SetMass(mass);
    }

    public void SetGravityScale(float gravityScale)
    {
        
    }

}
