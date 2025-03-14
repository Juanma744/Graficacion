using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Transform body;
    public float speedWalk = 5;
    public float jumpForce = 5;
    public bool onGround = false;
    public Animator anim;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        body = GetComponentInChildren<Transform>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //leer el movimiento horizontal
        bool crouched = Input.GetKey(KeyCode.LeftControl);//agacharse
        anim.SetBool("Crouch", crouched);
        //girar al personaje horizontalmente
        float direccion = body.localScale.x;
        if (h < 0)
            direccion = Mathf.Abs(body.localScale.x) * -1;
        else if (h > 0)
            direccion = Mathf.Abs(body.localScale.x);
        body.localScale = new Vector2(direccion, body.localScale.y);
        //detener al personaje cuando se agacha
        h = crouched ? 0 : h;
        //mover al personaje horizontalmente
        rb2d.velocity = new Vector2(h * speedWalk, rb2d.velocity.y);
        //aplicar animacion de caminar
        anim.SetBool("Walk", h != 0 ? true : false);
        //Salta si est[a en el suelo
        if (Input.GetButtonDown("Jump") && onGround)
        {
            rb2d.AddForce(new Vector2(0, jumpForce));
            //anim.SetBool("Jump", true);
        }
        else
        {
            //anim.SetBool("Jump", false);
        }
        anim.SetBool("Jump", !onGround);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jumper"))
            onGround = true;
        Debug.Log(other.name + "Enter");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Jumper"))
            onGround = false;
        Debug.Log(other.name + "Exit");
    }
}