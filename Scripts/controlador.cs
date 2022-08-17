using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class controlador : MonoBehaviour
{
    public TextMeshProUGUI vidasUI;
    public TextMeshProUGUI puntosUI;
    int vidas = 3;
    int puntos = 0;

    public Transform personaje;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
        vidasUI.text = vidas.ToString();  

    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void muerte(){
        vidas--;
        vidasUI.text = vidas.ToString();
        personaje.position = spawnPoint.position;
    }

     public void sumarPuntos(){
        puntos++;
        puntosUI.text = puntos.ToString();
    }
}
