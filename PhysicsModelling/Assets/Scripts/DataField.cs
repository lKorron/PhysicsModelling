using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class DataField : MonoBehaviour
{
    [SerializeField] protected BodyTransformer _body;
    protected InputField _inputField;

    protected virtual void Start()
    {
        _inputField = GetComponent<InputField>();
        _inputField.onValueChanged.AddListener(CheckFormat);
    }

    protected virtual void OnDisable()
    {
        _inputField.onValueChanged.RemoveAllListeners();
    }

    private void CheckFormat(string text)
    {
        if (float.TryParse(text, out float enteredHeight) == false || enteredHeight < 0)
            _inputField.text = "";
    }
}
