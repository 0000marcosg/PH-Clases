using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
  public JugadorMove scriptPersonaje;

    void OnTriggerEnter2D(Collider2D other){
        if (other.isTrigger == false){
            scriptPersonaje.grounded = true;
        }
    }
      
    void OnTriggerExit2D(Collider2D other){
        if (other.isTrigger == false){
            scriptPersonaje.grounded = false;
        }
    }

    //Esta pieza de código es puramente para evitar algunos bugs específicos con algunos elementos del template
    void OnTriggerStay2D(Collider2D other){
        if (other.isTrigger == false){
            scriptPersonaje.grounded = true;
        }
    }
}
