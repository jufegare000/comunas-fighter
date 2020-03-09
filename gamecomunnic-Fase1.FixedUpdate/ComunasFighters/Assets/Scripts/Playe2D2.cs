using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playe2D2 : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb2d;
    bool jump;
    public float jumpForce = 300f;
    public float direction = 0.0f;
    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("PlantadoP2", grounded);
        if (grounded)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                jump = true;
            }

        }
        MoveP2();
        GolpearP2();
        PatearFuerteP2();
        PatearSuperFuerteP2();
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
    public void MoveP2()
    {
        if (Input.GetKey(KeyCode.D))
        {
            direction = 1;
            anim.SetBool("CorrerP2", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("CorrerP2", true);
            direction = -1;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            anim.SetBool("CorrerP2", false);
            direction = 0;
        }
    }
    public void GolpearP2()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetTrigger("GolpearP2");
        }
    }
    public void PatearFuerteP2()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            anim.SetTrigger("PatearFuerteP2");
        }
    }
    public void PatearSuperFuerteP2()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            anim.SetTrigger("PatearSuperFuerteP2");
        }
    }
}
