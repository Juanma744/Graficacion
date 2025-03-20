using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Transform body;
    public float speedWalk = 10;
    public float jumpForce = 350;
    public bool onGraound = false;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        body = GetComponentInChildren<Transform>();
    }

    // Update is called once per frame
    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        //girar el personaje
        float direccion = body.localScale.x;
        if (h < 0)
        {
            direccion = Mathf.Abs(body.localScale.x) * -1;
        }
        else if (h > 0)
        {
            direccion = Mathf.Abs(body.localScale.x);
        }
        //agacharse pero no avanza
        bool crouded = Input.GetKey(KeyCode.LeftControl);
        h = crouded ? 0 : h;
        anim.SetBool("cruch",crouded);

        //avanza el personaje
        rb2d.velocity = new Vector2(h * speedWalk, rb2d.velocity.y);
        //animacion de caminar
        anim.SetBool("Walk", h!=0 ? true: false);

        //Brincar
        body.localScale = new Vector2(direccion, body.localScale.y);
        if (Input.GetButtonDown("Jump") && onGraound)
        {
            rb2d.AddForce(new Vector2(0, jumpForce));
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("jumper"))
            onGraound = true;
        Debug.Log(other.name+"Enter");

        //if (other.name == "coin" || other.name == "coin(clone)")
        //{
        //    other.GetComponentInChildren<Animator>().SetTrigger("pick");
        //    Destroy(other.gameObject, 0.55f);
        //    //acumular puntaje
        //}

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("jumper"))
            onGraound = false;
        Debug.Log(other.name+"Exit");
    }
}
