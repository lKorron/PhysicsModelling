using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class MechanicalTransformer : MonoBehaviour
{
    protected Transform _transform;

    protected virtual void Start()
    {
        _transform = GetComponent<Transform>();
    }

    public virtual void SetHeight(float height)
    {
        _transform.position = new Vector3(transform.position.x, height, transform.position.z);
    }

    public virtual void SetHeight(string stringHeight)
    {
        if (float.TryParse(stringHeight, out float height))
            SetHeight(height);
    }
}
