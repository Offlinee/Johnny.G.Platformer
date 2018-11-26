using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public string LevelToLoad = "Level 1";
    // om playern går in i objectet med denna script så laddas den banan som man har valt
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //aloa snack bar printas i cosole när man gå in i objectet med denna script
            print("aloa snack bar");
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
