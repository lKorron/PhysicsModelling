using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class StopwatchToggle : MonoBehaviour
{
    [SerializeField] private CollisionHandler _collisionHandler;
    private Toggle _toggle;

    private void Start()
    {
        if (_collisionHandler == null)
            _collisionHandler = FindObjectOfType<CollisionHandler>();

        _toggle = GetComponent<Toggle>();
        _toggle.onValueChanged.AddListener(_collisionHandler.SetAutomaticalStop);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveAllListeners();
    }

}
