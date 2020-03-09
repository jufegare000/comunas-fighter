using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2D : MonoBehaviour
{
    //public float speed = 10.0f;
    public Animator anim;
    public Rigidbody2D rb2d;
    bool jump;
    public float jumpForce = 300f;
    public float direction = 0.0f;
    public bool grounded;
    //public Vector2 mov;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Plantado", grounded);
        if (grounded)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                jump = true;
            }

        }
        Mover();
        Golpear();
        PatearFuerte();
        PatearSuperFuerte();
    }
    private void FixedUpdate()
    {
        
        if (jump)
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = false;
        }
        rb2d.velocity = new Vector2(direction * 5, rb2d.velocity.y);
    }


    public void Mover()
    {
        if (Input.GetKey(KeyCode.D))
        {
            direction = 1;
            anim.SetBool("Correr", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("Correr", true);
            direction = -1;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Correr", false);
            direction = 0;
        }
    }
    public void Golpear()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetTrigger("Golpear");
        }
    }
    public void PatearFuerte()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            anim.SetTrigger("PatearFuerte");
        }
    }
    public void PatearSuperFuerte()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            anim.SetTrigger("PatearSuperFuerte");
        }
    }
}
