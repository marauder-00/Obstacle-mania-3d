using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class force_script : MonoBehaviour
{
    public Rigidbody rb;
    public float forward=600f;
    public float backwards = -600f;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        rb.AddForce(0, 0, forward * Time.deltaTime, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, backwards * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
