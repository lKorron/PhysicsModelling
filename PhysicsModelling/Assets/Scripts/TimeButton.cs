using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TimeButton : MonoBehaviour
{
    [SerializeField] private string _stoppedTimeString;
    [SerializeField] private string _startedTimeString;
    private Button _button;
    private Text _buttonText;
    private bool _isTimeStopped;
    

    private void Start()
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

    private void StartTime()
    {
        _buttonText.text = _startedTimeString;
        Time.timeScale = 1f;
        _isTimeStopped = false;
    }

    private void StopTime()
    {
        _buttonText.text = _stoppedTimeString;
        Time.timeScale = 0f;
        _isTimeStopped = true;
    }

}
