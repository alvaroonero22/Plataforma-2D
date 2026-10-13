using System.Runtime.CompilerServices;
using UnityEngine; 
public enum HitboxTags
{
    Player,
    Enemy
} [RequireComponent(typeof(Collider2D))]
public class Hitbox : MonoBehaviour
{
    Collider2D myCollider2D;
    [SerializeField] HitboxTags tagToCompare;
    [SerializeField] float damage;
    [SerializeField] Vector2 pushForce;


    private bool isVulnerable;
    public bool IsVulnerable => isVulnerable;
    int xDirection;
    int yDirection;


    private void Start()
    {
        myCollider2D = GetComponent<Collider2D>();
        myCollider2D.isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tagToCompare.ToString()))
        {
            Health otherHealth = collision.gameObject.GetComponent<Health>();
            if (otherHealth != null)
            {
                if (!otherHealth.IsVulnerable) return;
                otherHealth.TakeDamage(damage);
                otherHealth.HandleVulnerabilityOnHit();                 //Añadir empuje al otro npc
                Rigidbody2D otherRB = collision.gameObject.GetComponent<Rigidbody2D>();
                if (otherRB != null)
                {
                    switch (collision.tag)
                    {

                        case "Player":
                            PushPlayer(otherRB);
                            break;

                    }



                }
            }
        }
    }

    private void PushPlayer(Rigidbody2D otherRB)
       

    {

        if (otherRB.linearVelocity.x >= 0)
        {
            xDirection = -1;
        }
        else
        {
            xDirection = 1;
        }
        if (otherRB.linearVelocity.y >= 0)
        {
            yDirection = 1;
        }
        else
        {
            yDirection = -1;
        }
        otherRB.linearVelocity = Vector3.zero;
        otherRB.AddForce(new Vector2(pushForce.x * xDirection, pushForce.y * yDirection), ForceMode2D.Impulse);
    }
}

    
