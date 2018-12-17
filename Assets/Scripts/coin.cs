using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int score = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // det är bara "palyer" som kan påverka denna object
        if (collision.tag == "Player")
        {
            //skapa en temporär variabel "controller" och till resultatet av sökningen efter objektet med taggen "GameController".
            GameObject controller = GameObject.FindWithTag("GameController");

            if (controller != null)
            {
                // skapa en temporär variabel "tracker" och sätt den till resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                // om den inte är lika med null Null = inte finns
                if (tracker != null)
                {
                    tracker.totalScore += score;
                }
                // om det är null så printas "ScoreTracker saknas på GameController."
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController.");
                }
                // förstör objectet                         
                Destroy(gameObject);
            }
        }
    }

}
