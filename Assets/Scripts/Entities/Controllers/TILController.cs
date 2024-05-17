using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TILController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<AttackSO> OnAttackEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
    public void CallAttackEvent(AttackSO attackSO)
    {
        OnAttackEvent?.Invoke(attackSO);
    }
}
