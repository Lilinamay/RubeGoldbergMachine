using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    bool KeyDown;
    public Rigidbody2D myBody;
    public float power;
    // Start is called before the first frame update
    void Start()
    {
        KeyDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (KeyDown == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myBody.AddForce((Vector2.up + Vector2.right) * power);
                KeyDown = true;
            }
        }
    }
}

