using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public string LevelToLoad = "Level 1";
    
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            print("aloa snack bar");
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
