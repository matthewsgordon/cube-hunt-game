using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplosionScript : MonoBehaviour
{
    public ParticleSystem Explosion;
    public bool Exploded = false;


     void OnCollisionEnter(Collision other)
    {
       /*
        * if a GameObject with the tag "Player" enters the mine's
        * collider, the particle effect of the explosion will occur,
        * a boolean called Exploded will be set to true and a function
        * called gameover will be invoked, after a 1 seconds delay.
        */
        if (other.gameObject.tag == "Player")
        {
            var Emission = Explosion.emission;
            var Duration = Explosion.duration; 

            Emission.enabled = true;
            Explosion.Play();

           Exploded = true;
           Invoke("gameover", 1f);
        }
    }

    /*
     * a function called gameover that will be invoked
     * once a mine has exploded that will take the player
     * to the gameover screen.
     */

    void gameover()
    {
        if (Exploded == true)
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
