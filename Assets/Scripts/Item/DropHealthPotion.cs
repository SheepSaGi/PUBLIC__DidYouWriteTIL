using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHealthPotion : MonoBehaviour
{
    [SerializeField] private HealthSystem characterHealth;
    [SerializeField] private int healAamount = 1;

    private HealthSystem enemyHealth;

    private void Awake()
    {
        enemyHealth = GetComponent<HealthSystem>();
    }

    private void Start()
    {
        enemyHealth.OnDeath += CreateItem;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 플레이어와 충돌했을 때
        {
            characterHealth.ChangeHealth(healAamount);
        }
    }

    void CreateItem()
    {
        GameObject obj = GameManager.Instance.ObjectPool.SpawnFromPool("HealthPotion");
        float x = Random.RandomRange(-2.5f, 2.5f);
        float y = Random.RandomRange(-3.5f, 3.5f);
        obj.transform.position = new Vector2(x, y);
    }
}
