using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour
{
    public Animator anim;
    public float value = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            anim.SetTrigger("pick");
            Destroy(gameObject, .40f);
        }
    }
}
