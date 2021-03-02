using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private StopwatchButton _stopwatchButton;

    private bool _isAutomaticallyStop;

    private void Start()
    {
        if (_stopwatchButton == null)
            _stopwatchButton = FindObjectOfType<StopwatchButton>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BaseSurface>() != null && _isAutomaticallyStop)
            _stopwatchButton.StopTime();
    }

    public void SetAutomaticalStop(bool booleanValue)
    {
        _isAutomaticallyStop = booleanValue;
    }
}
