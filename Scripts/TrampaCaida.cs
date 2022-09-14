using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampaCaida : MonoBehaviour
{
    // Se crea una referencia para el Rigidbody2D y para la posición inicial de la trampa
    Rigidbody2D rb;
    // Se crean variables para guardar la posición y rotación inicial de la trampa
    Vector3 posicion;
    Quaternion rotacion;

    void Start(){
        // Se carga el estado en el que comienza la plataforma y cargamos el Rigidbody2D 
        posicion = transform.position;
        rotacion = transform.rotation;
        rb = gameObject.GetComponent<Rigidbody2D>();
        //El Rigidbody comienza como estático
        rb.bodyType = RigidbodyType2D.Static;
    }


    //Función para ejecutarse cuando el objeto reciba el mensaje "Activar"
    void Activar(){
        // El Rigidbody2D se vuelve dinámico
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    void OnCollisionEnter2D (Collision2D other){
        // Cuando se colisiona con un objeto que NO tenga el tag "Player"
        if(!other.gameObject.tag.Equals("Player")){
            // Se reproduce el sonido que haya asignado en el componente AudioSource
      
            // La masa del Rigidbody se vuelve 500
            rb.mass =500.0f;
        }

        //NOTA: Se chequea que el objeto que colisiona no sea el player para evitar que el sonido se reproduzca si el jugador
        //salta encima del objeto. A su vez se aumenta la masa para que una vez caiga y choque con algo, el personaje no sea capaz
        //de empujarlo o moverlo.
    }

    // Se crea una función para que el GameController pueda resetear las trampas cuando el personaje muera
    void Reset(){
        // El Rigidbody vuelve a ser estático
        rb.bodyType = RigidbodyType2D.Static;
        // Se lleva al objeto a la posición y rotación que tenía al inicio del juego
        // NOTA: el Transform es un componente de solo lectura por lo cual no se puede reemplazar, solo igualar sus variables
        transform.position = posicion;
        transform.rotation = rotacion;

    }
}
