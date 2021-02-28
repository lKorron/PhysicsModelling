using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class StopwatchButton : MonoBehaviour
{
    [SerializeField] private Text _text;
    private Stopwatch _stopwatch;
    private TimeSpan _timeSpan;

    private void Start()
    {
        _stopwatch = new Stopwatch();
        _timeSpan = _stopwatch.Elapsed;
        StartStopwatch();
    }

    private void Update()
    {
        DisplayTime();
    }

    public void StartStopwatch()
    {
        _stopwatch.Start();
        
    }

    private void DisplayTime()
    {
        string timeString = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            _timeSpan.Hours, _timeSpan.Minutes, _timeSpan.Seconds,
            _timeSpan.Milliseconds / 10);
        _text.text = timeString;
        _stopwatch.Stop();
    }

}
