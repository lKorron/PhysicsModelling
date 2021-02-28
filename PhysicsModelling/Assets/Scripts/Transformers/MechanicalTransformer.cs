using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

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

    public UnityAction<string> ParseActionToString(UnityAction<float> method)
    {
        UnityAction<string> parseMethod = (str) =>
        {
            if (float.TryParse(str, out float parsedValue))
                method(parsedValue);
        };

        return parseMethod;

    }
}
