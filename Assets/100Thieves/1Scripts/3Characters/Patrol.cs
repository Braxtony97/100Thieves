using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    private List<Transform> _targetsList;
    private float _velocity;
    private Transform _currentTarget;
    private int _currentTargetIndex = 0;

    public void Initialize(List<Transform> targets, float velocity)
    {
        _targetsList = targets;
        _velocity = velocity;
        _currentTarget = _targetsList[_currentTargetIndex];
    }

    public void MoveToTarget()
    {
        if (_currentTarget != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, _currentTarget.position, _velocity * Time.deltaTime);

            if (Vector3.Distance(transform.position, _currentTarget.position) < 0.1f)
            {
                SwitchTarget();
            }
        }
    }

    private void SwitchTarget()
    {
        _currentTargetIndex = (_currentTargetIndex + 1) % _targetsList.Count;
        _currentTarget = _targetsList[_currentTargetIndex];
    }
}
