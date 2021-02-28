using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class DataField : MonoBehaviour
{
    [SerializeField] private string _placeholderText;
    [SerializeField] protected MechanicalTransformer _transformer;
    protected InputField _inputField;

    protected virtual void Start()
    {
        if (_transformer == null)
            _transformer = FindObjectOfType<MechanicalTransformer>();

        _inputField = GetComponent<InputField>();
        _inputField.onValueChanged.AddListener(CheckFormat);
        _inputField.placeholder.GetComponent<Text>().text = _placeholderText;
    }

    protected virtual void OnDisable()
    {
        _inputField.onValueChanged.RemoveAllListeners();
        _inputField.onEndEdit.RemoveAllListeners();
    }

    protected virtual void CheckFormat(string text)
    {
        if (float.TryParse(text, out float enteredHeight) == false || enteredHeight < 0)
            _inputField.text = "";
    }
}
