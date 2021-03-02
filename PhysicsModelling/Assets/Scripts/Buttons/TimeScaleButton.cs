using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleButton : TimeButton
{
    protected override void Start()
    {
        base.Start();
        _buttonText.text = _startedTimeString;
    }

    public override void StartTime()
    {
        base.StartTime();
        Time.timeScale = 1f;
    }

    public override void StopTime()
    {
        base.StopTime();
        Time.timeScale = 0f;
    }
}
