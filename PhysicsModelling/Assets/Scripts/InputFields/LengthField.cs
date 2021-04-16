using System.Collections;
using System.Collections.Generic;
using InputFields;
using UnityEngine;
using UnityEngine.Events;

public class LengthField : DataField
{
    protected override void Start()
    {
        base.Start();

        ILengtheningTransformer _planeTransformer = _transformer as ILengtheningTransformer;
        UnityAction<string> action = _planeTransformer.ParseActionToString(_planeTransformer.SetLength);

        _inputField.onEndEdit.AddListener(action);
    }
}
