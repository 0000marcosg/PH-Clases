using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activarTrampa : MonoBehaviour
{
    // Se crea la referencia para cuál va a ser el objeto a activar y luego de cuánto tiempo
   
    public GameObject trampa;
    public float tiempoActivacion;

    // El booleano activado se usa para detectar cuando el personaje entre en el trigger
    // "tiempo" va a funcionar como contador

    public bool activado = false;
    public float tiempo = 0;



    public bool ocultarGizmo = false;


    void Update()
    {
        // Si el personaje entró al trigger (activado == true)
        // Se empieza a sumar tiempo a la variable "tiempo"
        // Cuando esta variable supera el valor de "tiempoActivacion", la trampa se activa
        // luego el tiempo se resetea al igual que el booleano "activado"
        if (activado == true){
            tiempo += Time.deltaTime;
            if (tiempo >= tiempoActivacion){
                // La trampa debe tener el script "TrampaCaida" para que el mensaje funcione
                trampa.SendMessage("Activar");
                tiempo = 0;
                activado = false;
            }
        }
    }

    // Cuando el personaje entra en el trigger, "activado" se vuelve verdadera
    void OnTriggerEnter2D (Collider2D other){
        if (other.gameObject.tag.Equals("Player")){
            activado = true;
        }
    }


  
}
