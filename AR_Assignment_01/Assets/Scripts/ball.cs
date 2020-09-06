using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 5f;
    public float power = 0.1f;
    

    public GameObject goal;

    public Camera camera;

    Vector3 startpos;

    public bool held = false;

    public Rigidbody rb;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startpos = new Vector3 (touch.position.x, touch.position.y, 0);
                
                
            }

            if (touch.phase == TouchPhase.Moved)
            {
                

               
                
            }
            

            if (touch.phase == TouchPhase.Ended)
            {
                if (held)
                {
                    rb.AddForce((new Vector3(touch.position.x, 0, touch.position.y) - startpos) * power);
                }
                held = false;
            }
        }
        
        
    }
}   


