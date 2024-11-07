using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMain : MonoBehaviour
{
    [SerializeField] protected float _maxHealth;
    [SerializeField] protected float _moveSpeed;

    protected abstract void Patrol();
}
