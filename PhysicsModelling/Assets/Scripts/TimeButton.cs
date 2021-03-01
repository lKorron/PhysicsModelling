using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TimeButton : MonoBehaviour
{
    [SerializeField] private string _stoppedTimeString;
    [SerializeField] private string _startedTimeString;
    [SerializeField] private Button _button;
    private Text _buttonText;
    private bool _isTimeStopped;
    

    protected virtual void Start()
    {
        _button = GetComponent<Button>();
        _buttonText = _button.GetComponentInChildren<Text>();
        _button.onClick.AddListener(ChangeTime);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveAllListeners();
    }

    private void ChangeTime()
    {
        if (_isTimeStopped)
            StartTime();
        else
            StopTime();
    }

    protected virtual void StartTime()
    {
        _buttonText.text = _startedTimeString;
        _isTimeStopped = false;
    }

    protected virtual void StopTime()
    {
        _buttonText.text = _stoppedTimeString;
        _isTimeStopped = true;
    }

}
