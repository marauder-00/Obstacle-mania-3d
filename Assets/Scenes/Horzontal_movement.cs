using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horzontal_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float hrz_frc=500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            hrz_frc = hrz_frc * -1;
            rb.AddForce(hrz_frc*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            hrz_frc = hrz_frc * -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(hrz_frc*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else 
        {
            rb.AddForce(0, 0, 0);
        }
    }
}
