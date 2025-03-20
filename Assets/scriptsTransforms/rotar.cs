using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotar : MonoBehaviour
{
    public float angulo=45;
    public float speed = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, 0, angulo * Time.deltaTime * speed);
        }
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, 0, angulo * Time.deltaTime * speed * -1 );
        }
    }
}
