using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AngleField : DataField
{
    protected override void Start()
    {
        base.Start();
        PlaneTransformer _planeTransformer = _transformer as PlaneTransformer;
        UnityAction<string> action = _planeTransformer.ParseActionToString(_planeTransformer.SetAngle);

        _inputField.onEndEdit.AddListener(action);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        _inputField.onEndEdit.RemoveAllListeners();
    }

    protected override void CheckFormat(string text)
    {
        if (float.TryParse(text, out _) == false && text != "-")
        {
            _inputField.text = "";
        }
    }
}
