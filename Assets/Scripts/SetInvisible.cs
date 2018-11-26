using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{

    // Use this for initialization
    //gör objectet med denna script onsynligt
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
    
}
