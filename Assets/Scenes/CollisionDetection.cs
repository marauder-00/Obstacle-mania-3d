using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{ public Collider ground;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            GetComponent<force_script>().enabled = false;
            GetComponent<Horzontal_movement>().enabled = false;
            Debug.Log("Game Over");
        }
    }
}
