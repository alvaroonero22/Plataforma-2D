using UnityEngine;
public enum HitboxTag
{
    Player,
    Enemy
}

public class Hitbox : MonoBehaviour
{
    Collider2D mycollider2D;
    [SerializeField] HitboxTag tagToCompare;
    [SerializeField] float damage;

    private void Start()
    {
        mycollider2D = GetComponent<Collider2D>();
        mycollider2D.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tagToCompare.ToString()))
        {
            Health health = collision.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(damage);
                health.HandleVulnerabilityOnHit();
                Debug.Log("AUGHHH");
            }

        }
    }

 
    
}
