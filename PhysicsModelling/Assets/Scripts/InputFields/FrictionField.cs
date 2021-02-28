using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FrictionField : DataField
{
    protected override void Start()
    {
        base.Start();

        PlaneTransformer _planeTransformer = _transformer as PlaneTransformer;
        UnityAction<string> action = _planeTransformer.ParseActionToString(_planeTransformer.SetFriction);

        _inputField.onEndEdit.AddListener(action);
    }

    protected override void CheckFormat(string text)
    {
        if (float.TryParse(text, out float enteredHeight) == false || enteredHeight < 0 || enteredHeight > 1)
            _inputField.text = "";
    }
}
