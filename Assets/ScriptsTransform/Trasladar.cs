using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trasladar : MonoBehaviour
{
    public float tx;
    public float ty;    
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        tx = Input.GetAxis("Horizontal");
        ty = Input.GetAxis("Vertical");
        Vector2 traslationSpeed = new Vector2(tx, ty);
        transform.position += (Vector3)traslationSpeed * Time.deltaTime * speed;
    }
}
