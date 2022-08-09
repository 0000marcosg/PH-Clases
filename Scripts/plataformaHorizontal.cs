using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaHorizontal : MonoBehaviour
{
    Vector3 posicionInicial;
    float puntoA;
    float puntoB;
    public int direccion;
    public bool activada;

    public float distancia = 5;
    public float velocidad = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = this.transform.position;
        puntoA = posicionInicial.x;
        puntoB = posicionInicial.x + distancia;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        if (activada){    
            Vector3 traslado = new Vector3(velocidad*direccion*Time.deltaTime,0,0);
            transform.Translate(traslado);
        }


      
        if (gameObject.transform.position.x > puntoB){
            direccion = direccion * -1;
        }

        
        if (gameObject.transform.position.x < puntoA){     
            direccion = direccion * -1;
        }
    }
}
