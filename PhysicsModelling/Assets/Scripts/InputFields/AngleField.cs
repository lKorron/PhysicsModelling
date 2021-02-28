using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AngleField : DataField
{
    [SerializeField] private FixedBody _fixedBody;
    protected override void Start()
    {
        base.Start();
        PlaneTransformer _planeTransformer = _transformer as PlaneTransformer;
        UnityAction<string> action = _planeTransformer.ParseActionToString(_planeTransformer.SetAngle);
        UnityAction<string> fixedBodyAction = (str) =>
        {
            _fixedBody.SetZPosition();
        };

        _inputField.onEndEdit.AddListener(action);
        _inputField.onEndEdit.AddListener(fixedBodyAction);
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
