using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trasladar : MonoBehaviour
{
    public float tx;
    public float ty;
    public float spped;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tx = Input.GetAxis("Horizontal");
        ty = Input.GetAxis("Vertical");
        Vector2 traslationSeed = new Vector2(tx, ty);
        transform.position += (Vector3)traslationSeed * Time.deltaTime* spped;
    }
}
