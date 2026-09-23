using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Desesperación : MonoBehaviour
{
    //Definimos el contador a un tiempo de inicio 0
    private float contadorTiempo = 0f;
    // Definimos el segundo al que debe ocurrir la acción
    private float tiempoParaCambiar = 0.2f;
    private float Color;
    private float changeColor;

    private SpriteRenderer spriteRenderer;
   //Este awake hace que el 
    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        //Iniciamos el contador
       contadorTiempo += Time.deltaTime;
        //Conectamos el contador al segundo que debe cambiar para que ocurra la acción
      if(contadorTiempo >= tiempoParaCambiar)
            {

            contadorTiempo = 0;

            //spriteRenderer.color = Random.ColorHSV();

            changeColor(Color.HSVToRGB)



        }
    }

    private void changeColor(object hSVToRGB)
    {
        throw new NotImplementedException();
    }
}
