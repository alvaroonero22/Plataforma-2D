using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(BoxCollider2D))]
public class Health : MonoBehaviour
{
    BoxCollider2D boxCollider;


    float currentHealth;
   [SerializeField] int maxHealth = 100;
   [SerializeField] bool canDie;

    public UnityEvent OnHealthChanged;
    public UnityEvent OnDamageTaken;
    public UnityEvent OnHealthIncreased;
    public UnityEvent OnDeath;

    //Getters
    public float CurrentHealth => currentHealth;

    public float MaxHealth => maxHealth;
    private void Start()
    {
        ChangeHealth(maxHealth);
    }

    private void ChangeHealth(float newHealth)
    {
        currentHealth = Mathf.Clamp(newHealth, 0, maxHealth);
        OnHealthChanged.Invoke();
    }

    private void TakeDamage(float damage)
    {
        ChangeHealth(Mathf.Max(currentHealth - damage, 0));
        OnDamageTaken.Invoke();
        

        if (currentHealth == 0 && canDie)
        {
            OnDeath.Invoke();
        }
    }
    private void IncreaseHealth(float health)
    {
        ChangeHealth(health);
        OnHealthIncreased.Invoke();
        OnHealthChanged.Invoke();
    }

}
