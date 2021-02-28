using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LengthField : DataField
{
    protected override void Start()
    {
        base.Start();

        PlaneTransformer _planeTransformer = _transformer as PlaneTransformer;
        UnityAction<string> action = _planeTransformer.ParseActionToString(_planeTransformer.SetLength);

        _inputField.onEndEdit.AddListener(action);
    }
}
