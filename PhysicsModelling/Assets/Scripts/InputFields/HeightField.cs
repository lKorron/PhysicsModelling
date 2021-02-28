using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HeightField : DataField
{
    protected override void Start()
    {
        base.Start();
        UnityAction<string> action = _transformer.ParseActionToString(_transformer.SetHeight);
        _inputField.onEndEdit.AddListener(action);
    }

}
