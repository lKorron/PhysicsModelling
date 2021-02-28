using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedBody : MonoBehaviour
{
    [SerializeField] private float _startHeight;
    [SerializeField] private float _startIndent;
    [SerializeField] private PlaneTransformer _planeTransformer;

    private void Start()
    {
        SetZPosition();
    }

    private void Update()
    {
        SetZPosition();
    }

    public void SetZPosition()
    {
        var yPosition = _planeTransformer.gameObject.transform.position.y;
        var yProjection = _planeTransformer.Length * Mathf.Sin(_planeTransformer.Angle * Mathf.Deg2Rad);

        var zPosition = _planeTransformer.gameObject.transform.position.z;
        var zProjection = _planeTransformer.Length * Mathf.Cos(_planeTransformer.Angle * Mathf.Deg2Rad);
        var dynamicValue = Mathf.Round(Mathf.Cos(_planeTransformer.Angle * Mathf.Deg2Rad));
        var zDelta = _startIndent * dynamicValue;

        transform.position = new Vector3(0, yPosition + yProjection + _startHeight, zPosition - zProjection + zDelta);
    }

    
}
