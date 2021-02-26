using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class DataField : MonoBehaviour
{
    [SerializeField] private string _placeholderText;
    [SerializeField] protected BodyTransformer _body;
    protected InputField _inputField;

    protected virtual void Start()
    {
        if (_body == null)
            _body = FindObjectOfType<BodyTransformer>();

        _inputField = GetComponent<InputField>();
        _inputField.onValueChanged.AddListener(CheckFormat);
        _inputField.placeholder.GetComponent<Text>().text = _placeholderText;
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
