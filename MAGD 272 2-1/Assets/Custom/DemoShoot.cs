using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoShoot : MonoBehaviour
{
    public Transform shootPosition;

    public GameObject projectile;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        Instantiate(projectile, shootPosition.position, Quaternion.identity);
    }
}
