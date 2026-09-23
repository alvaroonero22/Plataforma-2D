using System;
using Unity.VisualScripting;
using UnityEngine;

public class NPC : MonoBehaviour
{

    GameObject groundGo;
    [SerializeField] private Color newColor;
    private SpriteRenderer spriteRenderer;
  
    [SerializeField] private float colorchangespeed = 0.2f;
    private void Awake()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();               ///
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log(ReturnNameString("cuca", 20));
        //Debug.LogWarning(ReturnNameString("Alberto", 34));
        //Debug.LogError(ReturnNameString("Sofia", 15));

        ChangeColor(newColor);
    }

    // Update is called once per frame
    void Update()
    {
        float hue = (Time.time * 0.2F) + 1;
        Color color = Color.HSVToRGB(hue, 1f, 1f);
        ChangeColor(color);
    }
    /// <summary>
    /// Debug lo muestra en la consola, también nos dice donde se rompe el código.
    /// Ctrl RR + seleccionar una palabra hace que puedas modificar todos los nombres iguales.
    /// Shift + 777  o /// enseña los parametros.
    /// [SerializeField] sirve para solo cambiarlo desde Unity o desde el propio código.
    /// [NonSerialized] "Aunque el valor sea público, no lo enseñes por Unity."
    /// Tab sirve para colocar la respuesta si ya sale (Ej: Autocompleta.. pu*** te pone public)
    /// </summary>
    /// 

 
    
    private void ChangeColor(Color color)
    {
        spriteRenderer.color = color;
    }

    /// <summary>
    /// My function returns a string with the name and age of an user
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <returns></returns>
    private string ReturnNameString(string name, int age)
    {
        return "Me llamo" + name + "y tengo" + age + "años.";
    }
}