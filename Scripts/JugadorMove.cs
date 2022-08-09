using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMove : MonoBehaviour
{
    public bool grounded;

    public float dirX;
    public Rigidbody2D rb;
    public float velocidad;
    public float velSalto;

  
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
         dirX = Input.GetAxisRaw("Horizontal") * velocidad;

         if (Input.GetButtonDown("Jump") && grounded){
            rb.AddForce(Vector2.up * velSalto, ForceMode2D.Impulse);
         }
    }

    void FixedUpdate(){
        rb.velocity = new Vector2 (dirX,rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other){
         if (other.gameObject.tag.Equals("Plataforma"))
        {
            grounded = true;
            this.transform.parent = other.transform;
        }
    }

    void OnCollisionExit2D(Collision2D other){
        if (other.gameObject.tag.Equals("Plataforma"))
        {
            this.transform.parent = null;
        }
    }
}
