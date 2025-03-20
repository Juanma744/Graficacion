using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootWeapon : MonoBehaviour
{
    public GameObject basicBullet;
    public Transform bulletSpawn;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(basicBullet,bulletSpawn.position,bulletSpawn.rotation);
        }
    }

}
