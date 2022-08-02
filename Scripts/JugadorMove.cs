using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMove : MonoBehaviour
{
    public float dirX;
    public Rigidbody2D rb;
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
         dirX = Input.GetAxisRaw("Horizontal") * velocidad;
    }

    void FixedUpdate(){
        rb.velocity = new Vector2 (dirX,rb.velocity.y);
    }

    void OnCollisionEnter2D(){
        print("piso");
    }

    void OnCollisionExit2D(){
        print("aire");
    }
}
