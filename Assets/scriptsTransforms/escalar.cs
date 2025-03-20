using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escalar : MonoBehaviour
{
    public float sx;
    public float sy;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 scalationFactor = new Vector2(sx, sy);
        if (Input.GetKeyDown(KeyCode.M))
        {
            transform.localScale *= scalationFactor;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            transform.localScale /= scalationFactor;
        }


    }
}
