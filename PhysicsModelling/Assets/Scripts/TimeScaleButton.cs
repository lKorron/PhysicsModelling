using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScaleButton : TimeButton
{
    protected override void StartTime()
    {
        base.StartTime();
        Time.timeScale = 1f;
    }

    protected override void StopTime()
    {
        base.StopTime();
        Time.timeScale = 0f;
    }
}
