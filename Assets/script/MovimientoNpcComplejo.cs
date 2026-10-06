using UnityEngine;

public class MovimientoNPC : MonoBehaviour
{
    // Variables que puedes modificar desde el Inspector de Unity
    public float velocidad = 2f;
    public float tiempoPorDireccion = 2f;

    // Lista de las direcciones que va a tomar
    private Vector2[] direcciones;
    private int indiceDireccion = 0;
    private float temporizador = 0f;

    void Start()
    {
        // Definimos la secuencia de 4 direcciones.
        // Al moverse igual en estas 4 direcciones, formará un cuadrado 
        // y terminará exactamente en el punto de inicio.
        direcciones = new Vector2[]
        {
            Vector2.right, // derecha (X: 1, Y: 0)
            Vector2.up,    //arriba    (X: 0, Y: 1)
            Vector2.left,  // izq   (X:-1, Y: 0)
            Vector2.down   //abajo     (X: 0, Y:-1)
        };
    }

    void Update()
    {
        // 1. Movemos el NPC en la dirección actual
        // Time.deltaTime asegura que el movimiento sea suave sin importar los FPS
        transform.Translate(direcciones[indiceDireccion] * velocidad * Time.deltaTime);

        // 2. Sumamos el tiempo que ha pasado al temporizador
        temporizador += Time.deltaTime;

        // 3. Comprobamos si ya es hora de cambiar de dirección
        if (temporizador >= tiempoPorDireccion)
        {
            temporizador = 0f; // Reiniciamos el reloj a cero
            indiceDireccion++; // Pasamos a la siguiente dirección en la lista

            // Si llegamos al final de la lista, volvemos a empezar desde la primera
            if (indiceDireccion >= direcciones.Length)
            {
                indiceDireccion = 0;
            }
        }
    }
}