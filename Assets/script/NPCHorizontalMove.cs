using Unity.VisualScripting;
using UnityEngine;
public class NPCHorizontalMove : MonoBehaviour
{
    private float speed = 15f; // Speed of the NPC movement
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float contadorTiempo = 0f;

    private float tiempoParaCambiar = 2f;
    Vector3 direction;
    void Start()
    {
        direction = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
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
        transform.Translate(direction * speed * Time.deltaTime);
    }
}



