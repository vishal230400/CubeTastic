using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Playerbehavior : MonoBehaviour
{

    public Rigidbody rigidbody;
    public float forward = 500f;
    public float sideward = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, forward*Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            rigidbody.AddForce(sideward * Time.deltaTime, 0, 0);
        }
        
        if(Input.GetKey("a"))
        {
            rigidbody.AddForce(-sideward * Time.deltaTime, 0, 0);
        }
        
        if(rigidbody.position.y<-1)
        {
            FindObjectOfType<Game>().EndGame();
        }
    
    }
}
