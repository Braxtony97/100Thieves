using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : EnemyMain
{
    [SerializeField] private Patrol _patrol;
    [SerializeField] private List<Transform> _targets;

    private void Start()
    {
        _patrol.Initialize(_targets, _moveSpeed);
    }

    private void Update()
    {
        Patrol();
    }

    protected override void Patrol()
    {
        _patrol.MoveToTarget();
    }
}
