using Unity.VisualScripting;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField] private int healAamount = 1;
    [SerializeField] SpriteRenderer healthPotionSprite;
    [SerializeField] CircleCollider2D healthPotionCollider;

    private AudioSource effect;
    public AudioClip healSoundClip;

    bool isUsed;
    float timeAfterUsed;

    public void Start()
    {
        effect = GetComponent<AudioSource>();
        healthPotionSprite = GetComponent<SpriteRenderer>();
        healthPotionCollider = GetComponent<CircleCollider2D>();
    }

    public void OnEnable() // 오브젝트가 활성화 되었을 때 실행
    {
        isUsed = false;
        timeAfterUsed = 0;
        healthPotionSprite.enabled = true;
        healthPotionCollider.enabled = true;
    }

    public void Update()
    {
        if (isUsed)
        {
            timeAfterUsed += Time.deltaTime;
            if (timeAfterUsed > 1)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // 플레이어와 충돌했을 때
        {
            effect.Play();

            HealthSystem healthSystem = collision.GetComponent<HealthSystem>();
            if (healthSystem.CurrentHealth < healthSystem.MaxHealth)
            {
                healthSystem.ChangeHealth(healAamount);               
            }

            isUsed = true;
            healthPotionSprite.enabled = false;
            healthPotionCollider.enabled = false;

        }
    }
}
