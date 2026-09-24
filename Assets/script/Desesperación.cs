using UnityEngine;

public class Desesperación : MonoBehaviour
{
    //Definimos el contador a un tiempo de inicio 0
    private float contadorTiempo = 0f;
    // Definimos el segundo al que debe ocurrir la acción
    private float tiempoParaCambiar = 0.2f;
    private float changeColor;

    private float randomHue;
    private float randomSaturation;
    private float randomValue;

    private float maxSaturation = 80f;
    private float minSaturation = 0f;

    private float minHue = 0f;
    private float maxHue = 360f;

    private float minValue = 20f;
    private float maxValue = 80f;

    private SpriteRenderer spriteRenderer;
   //Este awake hace que el 
    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        //  //Iniciamos el contador
        // contadorTiempo += Time.deltaTime;
        //  //Conectamos el contador al segundo que debe cambiar para que ocurra la acción
        //if(contadorTiempo >= tiempoParaCambiar)
        //      {

        //      contadorTiempo = 0;

        //      // spriteRenderer.color = Random.ColorHSV();


        contadorTiempo += Time.deltaTime;
        if (contadorTiempo >= tiempoParaCambiar)
        {
            randomHue = UnityEngine.Random.Range(minHue, maxHue);
            randomSaturation = UnityEngine.Random.Range(minSaturation, maxSaturation);
            randomValue = UnityEngine.Random.Range(minValue, maxValue);

            ChangeColor(Color.HSVToRGB(randomHue / 360f, randomSaturation / 100f, randomValue / 100f));
        }
    }

    private void ChangeColor(Color color)
    {
        spriteRenderer.color = color;
    }
}
    


