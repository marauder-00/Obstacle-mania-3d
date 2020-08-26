using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{ public Collider ground;
    bool once;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            GetComponent<force_script>().enabled = false;
            GetComponent<Horzontal_movement>().enabled = false;
            
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collision.collider.tag == "Finish")
        {
            if (!once)
            {
                FindObjectOfType<GameManager>().Complete();
                print("complete");
                once = true;
            }
        }
    }
}
