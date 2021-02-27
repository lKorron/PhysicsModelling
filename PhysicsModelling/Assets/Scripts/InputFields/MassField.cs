using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassField : DataField
{
    protected override void Start()
    {
        base.Start();
        _inputField.onEndEdit.AddListener(_body.SetMass);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        _inputField.onEndEdit.RemoveAllListeners();
    }
}
