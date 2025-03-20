using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovment : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float bulletSpeed = 10;
    public float direccion;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        direccion = GameObject.Find("Player").transform.localScale.x;
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = Vector2.right * bulletSpeed*direccion;
    }
}
