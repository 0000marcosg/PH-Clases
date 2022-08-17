using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recolectable : MonoBehaviour
{
  // Se crea una referencia para el script "controlador" del objeto GameController
    public controlador controlador;
    
    void Start()
    {
        // Se carga el script buscando al objeto de nombre "GameController"
        controlador = GameObject.Find("Controlador").GetComponent<controlador>();
    }

    // Cuando el personaje entra en el trigger, se ejecuta la función sumarPuntos y se destruye este objeto
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            controlador.sumarPuntos();
            Destroy(gameObject);   
        }
    }
}
