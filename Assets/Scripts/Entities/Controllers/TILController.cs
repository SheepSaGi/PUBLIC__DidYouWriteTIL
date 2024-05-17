using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TILController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action OnAttackEvent;// TODO : <AttackSO> 추가

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
    public void CallAttackEvent()//TODO: AttackSO 추가
    {
        OnAttackEvent?.Invoke();
    }
}
