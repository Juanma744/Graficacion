using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinControler : MonoBehaviour
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
        if (other.name == ("Player"))
        {
            gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            anim.SetTrigger("Drop");
            Destroy(gameObject, 0.5f);
            Debug.Log("Coin taken");
        }
    }
}

