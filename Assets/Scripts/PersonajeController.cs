using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        float dirX = Input.GetAxisRaw("Horizontal");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector2 velocidad = new Vector2();

        rb.velocity = new Vector2(dirX * 5, rb.velocity.y);

        if (Input.GetButtonDown("Jump")) {
            rb.velocity = new Vector2(rb.velocity.x, 6);
   }

    }
}
