using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{

    public Animator animator;
    private SpriteRenderer sprite;

    public int runSpeed=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
         Rigidbody2D rb = GetComponent<Rigidbody2D>();
         sprite = GetComponent<SpriteRenderer>();
         float dirX = Input.GetAxis("Horizontal");
        if(dirX != 0){
            rb.velocity = new Vector2(dirX * runSpeed, rb.velocity.y);
             sprite.flipX = dirX < 0;
             animator.SetBool("Run",true);

        
        }else{
            animator.SetBool("Run",false);
            //rb.velocity = new Vector2(0, rb.velocity.y);
        }
        

        if (Input.GetButtonDown("Jump")) {
            rb.velocity = new Vector2(rb.velocity.x, 7);
            animator.SetBool("Run",false);
            animator.SetBool("Jump",true);
        }
        



    }
}
