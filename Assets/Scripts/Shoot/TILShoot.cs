using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.Properties;
using UnityEngine;

using UnityEngine.Pool;


public class TILShoot : MonoBehaviour
{
    private TILController controller;

    //private ObjectPool objectPool;

    [SerializeField] private Transform bulletSpawnPosition;
    private Vector2 aimDirection = Vector2.up;

    public GameObject CharacterBulletPrefab;

    private void Awake()
    {
        controller = GetComponent<TILController>();
        //objectPool = GetComponent<ObjectPool>();
    }

    private void Start()
    {
        controller.OnAttackEvent += Onshoot;
        controller.OnLookEvent += OnAim;
    }
    private void OnAim(Vector2 newAimDirection)
    {
        aimDirection = newAimDirection;
    }
    
    private void Onshoot(AttackSO attackSO)
    {
        //AttackSO AttackSO = attackSO as AttackSO;
        //float projectilesAngleSpace =AttackSO.multipleProjectilesAngel;
        //int numberOfProjectilesPerShot = AttackSO.numberofProjectilesPerShot;

        // 중간부터 펼쳐지는게 아니라 minangle부터 커지면서 쏘는 것으로 설계했어요! 
        //float minAngle = -(numberOfProjectilesPerShot / 2f) * projectilesAngleSpace + 0.5f * RangedAttackSO.multipleProjectilesAngel;

        CreateProjectile(attackSO);    
    }

    private void CreateProjectile(AttackSO attackSO)
    {
        GameObject obj = GameManager.Instance.ObjectPool.SpawnFromPool(attackSO.bulletNameTag);
        obj.transform.position = bulletSpawnPosition.position;
        BulletController attackController = obj.GetComponent<BulletController>();
        attackController.InitializeAttack(RotateVector2(aimDirection), attackSO);
        //Instantiate(CharacterBulletPrefab, bulletSpawnPosition.position, Quaternion.identity);
    }

    private static Vector2 RotateVector2(Vector2 v)
    {
        return Quaternion.Euler(0f, 0f, 0) * v;
    }
}
