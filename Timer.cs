using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public float Time_Current;
    public float Time_Start = 180;
    public TMP_Text Time_Text;

    
    void Start()
    {
       /*
        * The current time is set to the starting time
        */
        Time_Current = Time_Start;
    }

    // Update is called once per frame
    void Update()
    {
       /*
        * The current time will count down by 1 every second
        * until it reaches 0
        * The current time is converted into a string to be shown
        * in a text mesh pro canvas so the player can see how much
        * time they have
        */ 
        if (Time_Current > 0)
        {
            Time_Current = Time_Current - 1 * Time.deltaTime;
        }
        Time_Text.text = "Time: " + Time_Current.ToString("0");

        /*
         * Once the current time reaches 0 the
         * player will be taken to the game over scene.
         */
        if (Time_Current < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
}
