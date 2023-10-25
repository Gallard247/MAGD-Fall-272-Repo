using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInput : MonoBehaviour
{
    Rigidbody2D rb;

    private float horVal;
    private float verVal;


    public bool facingRight;

    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = 5;
        horVal = Input.GetAxisRaw("Horizontal");
        verVal = Input.GetAxisRaw("Vertical");
        if (horVal != 0 && verVal != 0)
        {
            speed = 3.5f;
        }
        flip();
    }

    void FixedUpdate()
    {
       // rb.AddForce(new Vector2 (horVal * speed, verVal * speed));
       rb.velocity = new Vector2 (horVal * speed, verVal * speed);
    }

    void flip()
    {

        if ((horVal > 0 && facingRight) || (horVal < 0 && !facingRight))
        {
            facingRight = !facingRight;
            transform.Rotate(0, 180, 0);
        }
    }
}
