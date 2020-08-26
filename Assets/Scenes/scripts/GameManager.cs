using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool end = false;
 
    public GameObject anim;
    public void EndGame()
    {
        if (end == false)
        {
            end = true;
            Debug.Log("Game Over");
            
            Invoke("Restart", 1.0f);   
        }
      
    }
    public void Complete()
    {
        anim.SetActive(true);
 
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
