using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    // Se crea una referencia para el transform del objeto de destino
    public Transform destino;

    // Cuando un objeto de tag "Player" entra en el trigger, dicho objeto se envía a la posición del objeto "destino"
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag.Equals("Player")){
            other.transform.position = destino.position;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
