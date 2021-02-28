using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MassField : DataField
{
    protected override void Start()
    {
        base.Start();
        BodyTransformer bodyTransformer = _transformer as BodyTransformer;
        UnityAction<string> action = bodyTransformer.ParseActionToString(bodyTransformer.SetMass);
        _inputField.onEndEdit.AddListener(action);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        _inputField.onEndEdit.RemoveAllListeners();
    }
}
