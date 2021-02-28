using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IndentField : DataField
{
    protected override void Start()
    {
        base.Start();
        FixedBody fixedBody = _transformer as FixedBody;
        UnityAction<string> action = fixedBody.ParseActionToString(fixedBody.SetIndent);
        _inputField.onEndEdit.AddListener(action);
    }
}
