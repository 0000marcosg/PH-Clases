using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraMove : MonoBehaviour
{
   public Transform personaje;


    void Update()
    {
        transform.position = new Vector3(personaje.transform.position.x,personaje.transform.position.y,transform.position.z);
        
    }
}
