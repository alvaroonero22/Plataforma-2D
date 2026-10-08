using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(BoxCollider2D))]
public class Health : MonoBehaviour
{
    BoxCollider2D boxCollider;

    float currentHealth;
    [SerializeField] int maxHealth = 100;
    [SerializeField] bool canDie = true;
    bool isVulnerable = true;
    public float invulnerabilityTime = 2f;

    [SerializeField] Color flashColor;
    Color originalColor;
    SpriteRenderer spriteRenderer;
    [SerializeField] float flashTime = 0.2f;




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
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalColor = spriteRenderer.color;
        flashColor = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f); 
    }

    private void ChangeHealth(float newHealth)
    {
        currentHealth = newHealth;
        OnHealthChanged.Invoke();
    }

    public void TakeDamage(float damage)
    {
        if (!isVulnerable) return;

        ChangeHealth(Mathf.Max(0, currentHealth - damage));
        OnDamageTaken.Invoke();

        if (currentHealth == 0 && canDie)
        {
            OnDeath.Invoke();
        }
    }

    private void IncreaseHealth(float amountToHeal)
    {
        ChangeHealth(Mathf.Min(maxHealth, currentHealth + amountToHeal));
        OnHealthIncreased.Invoke();
    }

    public void HandleVulnerabilityOnHit()
    {
        if (!isVulnerable) return;

        isVulnerable = false;
        StartCoroutine(WaitToMakeVulnerable());
        StartCoroutine(InvulnerabilityFlash());
    }

    IEnumerator WaitToMakeVulnerable()
    {
        yield return new WaitForSeconds(invulnerabilityTime);
        isVulnerable = true;
    }

    IEnumerator InvulnerabilityFlash()
    {

        while (!isVulnerable)
        {
            spriteRenderer.color = flashColor;
            yield return new WaitForSeconds(flashTime);
            spriteRenderer.color = originalColor;
            yield return new WaitForSeconds(flashTime);
        }
    }
}