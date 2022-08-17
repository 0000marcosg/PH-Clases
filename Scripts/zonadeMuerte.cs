using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonadeMuerte : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        // Cuando un objeto con el tag "Player" entra en el Trigger...
        if (other.gameObject.tag.Equals("Player")){
            // Se busca al objeto de nombre "GameController" y se le envía el mensaje "muerte"
            GameObject.Find("Controlador").SendMessage("muerte");
        }
    }   
}
