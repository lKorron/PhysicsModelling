using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TimeButton : MonoBehaviour
{
    [SerializeField] protected string _stoppedTimeString;
    [SerializeField] protected string _startedTimeString;
    [SerializeField] private Button _button;
    protected Text _buttonText;
    protected bool _isTimeStopped;
    

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

    public virtual void StartTime()
    {
        _buttonText.text = _startedTimeString;
        _isTimeStopped = false;
    }

    public virtual void StopTime()
    {
        _buttonText.text = _stoppedTimeString;
        _isTimeStopped = true;
    }

    private void ChangeTime()
    {
        if (_isTimeStopped)
            StartTime();
        else
            StopTime();
    }

   

}
