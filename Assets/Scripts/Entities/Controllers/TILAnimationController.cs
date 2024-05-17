using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class TILAnimationController : MonoBehaviour
{
    protected Animator animator;
    //protected TopDownController controller;

    private static readonly int IsWalking = Animator.StringToHash("isWalking");
    protected static readonly int IsHit = Animator.StringToHash("isHit");
    private static readonly int Attack = Animator.StringToHash("Attack");

    private readonly float magnituteThreshold = 0.5f;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        // 공격하거나 움직일 때 애니메이션이 같이 반응하도록 구독
        //controller.OnAttackEvent += Attacking;
        //controller.OnMoveEvent += Move;
    }

    // 이동
    /*private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > magnituteThreshold);
    }*/

    // 공격
    private void Attacking(AttackSO obj)
    {
        animator.SetTrigger(Attack);
    }

    // 피격
    private void Hit()
    {
        animator.SetBool(IsHit, true);
    }

    // 피격당하는 동안은 무적 상태
    private void InvincibilityEnd()
    {
        animator.SetBool(IsHit, false);
    }
}
