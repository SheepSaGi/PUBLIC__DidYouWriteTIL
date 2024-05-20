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

    private ObjectPool objectPool;

    [SerializeField] private Transform bulletSpawnPosition;
    private Vector2 aimDirection = Vector2.right;

    public GameObject CharacterBulletPrefab;

    private void Awake()
    {
        controller = GetComponent<TILController>();
        objectPool = GetComponent<ObjectPool>();
    }

    private void Start()
    {
        controller.OnAttackEvent += Onshoot;
    }
    //private void OnAim(Vector2 newAimDirection)
    //{
    //    aimDirection = newAimDirection;
    //}

    private void Onshoot(AttackSO sO)
    {
        CreateProjectile();    
    }

    private void CreateProjectile()
    {

        GameObject obj = objectPool.SpawnFromPool("Arrow");
        obj.transform.position = bulletSpawnPosition.position;
        BulletController attackController = obj.GetComponent<BulletController>();

        //Instantiate(CharacterBulletPrefab, bulletSpawnPosition.position, Quaternion.identity);
    }

    private Vector2 RotateVector2(Vector2 v)
    {
        return Quaternion.Euler(0, 0, 0) * v;
    }
}
