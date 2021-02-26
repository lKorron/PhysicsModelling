using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightField : DataField
{
    protected override void Start()
    {
        base.Start();
        _inputField.onEndEdit.AddListener(_body.ChangeHeight);
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        _inputField.onEndEdit.RemoveAllListeners();
    }
}
