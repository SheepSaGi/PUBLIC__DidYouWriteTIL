using Unity.VisualScripting;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField] private int healAamount = 1;
    
    private AudioSource effect;
    public AudioClip healSoundClip;

    public void Start()
    {
        effect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // 플레이어와 충돌했을 때
        {
            HealthSystem healthSystem = collision.GetComponent<HealthSystem>();
            if (healthSystem.CurrentHealth < healthSystem.MaxHealth)
            {
                healthSystem.ChangeHealth(healAamount);               
            }
            
            effect.PlayOneShot(healSoundClip);

            gameObject.SetActive(false);
        }
    }
}
