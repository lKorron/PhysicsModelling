using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class DataField : MonoBehaviour
{
    [SerializeField] private BodyTransformer _body;
    private InputField _inputField;

    private void Start()
    {
        _inputField = GetComponent<InputField>();
        _inputField.onEndEdit.AddListener(_body.ChangeHeight);
        _inputField.onValueChanged.AddListener(CheckFormat);
    }

    private void OnDisable()
    {
        _inputField.onEndEdit.RemoveAllListeners();
        _inputField.onValueChanged.RemoveAllListeners();
    }

    private void CheckFormat(string text)
    {
        float enteredHeight;

        if (float.TryParse(text, out enteredHeight) == false || enteredHeight < 0)
        {
            _inputField.text = "";
        }
    }
}
