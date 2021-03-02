
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopwatchButton : TimeButton
{
    [SerializeField] private Text _text;
    private float _time;
    private int _minutes;
    private int _seconds;
    private int _milliseconds;
    private bool _isStopwatchStarted;

    protected override void Start()
    {
        base.Start();
        DisplayTime();
        _isTimeStopped = true;
        _buttonText.text = _stoppedTimeString;
    }

    private void Update()
    {
        if (_isStopwatchStarted)
            ComputeTime();
        
    }

    public void ClearTime()
    {
        _time = 0;
        _minutes = 0;
        _seconds = 0;
        _milliseconds = 0;
        DisplayTime();
    }

    public override void StartTime()
    {
        base.StartTime();
        _isStopwatchStarted = true;
    }

    public override void StopTime()
    {
        base.StopTime();
        _isStopwatchStarted = false;
    }

    private void DisplayTime()
    {
        string timeString = string.Format("{0:00}:{1:00}:{2:00}", _minutes, _seconds, _milliseconds);
        _text.text = timeString;

    }

    private void ComputeTime()
    {
        _time += Time.deltaTime;
        _minutes = (int)(_time / 60 % 60);
        _seconds = (int)(_time % 60);
        _milliseconds = (int)((_time - (int)_time) * 100);

        DisplayTime();
    }

}
