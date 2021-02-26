using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Rigidbody))]
public class BodyTransformer : MonoBehaviour
{
    private Transform _transform;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void ChangeHeight(float height)
    {
        _transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }

    public void ChangeHeight(string stringHeight)
    {
        if (float.TryParse(stringHeight, out float height))
            ChangeHeight(height);
    }

    public void ChangeMass(float mass)
    {
        _rigidbody.mass = mass;
        var scaler = Mathf.Pow(mass, 1f / 3f);
        _transform.localScale = Vector3.one * scaler;
    }

    public void ChangeMass(string stringMass)
    {
        if (float.TryParse(stringMass, out float mass))
            ChangeMass(mass);
    }

    public void ChangeGravityScale(float gravityScale)
    {
        
    }

}
