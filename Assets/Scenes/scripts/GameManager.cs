using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public bool end = false;
    public void EndGame()
    {
        if (end == false)
        {
            end = true;
            Debug.Log("Game Over");
            //    Invoke("Restart", 2);
            Invoke("Restart", 2.0f);   
        }
      
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
