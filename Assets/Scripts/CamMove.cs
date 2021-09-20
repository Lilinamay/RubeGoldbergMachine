using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // private void OnCollisionEnter2D(Collision2D collision)
    //{
    //   Debug.Log("hit something");
    //   if(collision.gameObject.name == "Square (3)")
    //  {
    //      Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y,-10);
    //      Camera.main.transform.position = newCamPos;

    // }

    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit something");
        if (collision.gameObject.name == "CamMove1")
        {
            Debug.Log("hit box");
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10);
            Camera.main.transform.position = newCamPos;

        }

        if (collision.gameObject.name == "CamMove2")
        {
            Debug.Log("hit box");
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10);
            Camera.main.transform.position = newCamPos;
        }

        if (collision.gameObject.name == "CamMove3")
        {
            Debug.Log("hit box");
            
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y+0.4f, -10);
            Camera.main.transform.position = newCamPos;
        }

        if (collision.gameObject.name == "CamMove4")
        {
            Debug.Log("hit box");
            Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y+0.5f, -10);
            Camera.main.transform.position = newCamPos;
        }
    }
}
