using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demohealth : MonoBehaviour
{
    public int health = 100;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(health);
    }

    void TakeDamage()
    {
        health -= 5;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage();
        }
    }
}
