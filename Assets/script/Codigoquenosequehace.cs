using UnityEngine;

namespace SimpleMovement
{
    public enum SimpleMovementTypes
    {
        Horizontal,
        Vertical,
        Diagonal
    }
    public class NPCSimpleMovement : MonoBehaviour
    {

       [SerializeField] private float speed = 2f; // Speed of the NPC movement

        [SerializeField] private float contadorTiempo = 0;
        [SerializeField] private float tiempoParaCambiar = 2f;

        Rigidbody2D rb;
        Vector3 direction;
        [SerializeField] SimpleMovementTypes movementType;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();

            if (movementType == SimpleMovementTypes.Horizontal)
            {
                direction = new Vector3(1, 0, 0); //Vector3.right
                rb.gravityScale = 1;
            }
            else if (movementType == SimpleMovementTypes.Vertical)
            {
                direction = new Vector3(0, 1, 0); //Vector3.up
                rb.gravityScale = 0;
            }
            else
            {
                direction = new Vector3(1, 1, 0);
                rb.gravityScale = 0;
            }
        }

        private void Update()
        {
            UpdateDirection();
            UpdateMovement();
        }

        private void UpdateDirection()
        {
            contadorTiempo += Time.deltaTime;

            if (contadorTiempo >= tiempoParaCambiar)
            {
                contadorTiempo = 0f; // Reset the timer
                speed = -speed; // Reverse the direction of movement   
            }
        }
        private void UpdateMovement()
        {
            transform.Translate((direction * speed * Time.deltaTime));
        }
    }
}