using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeDemo : MonoBehaviour
{
    // Start is called before the first frame update

    float mySpeed = 0.4f;
    int lives = 3;
    string myName = "Sam";
    void Start()
    {
        print(mySpeed + lives + myName);
        print("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
