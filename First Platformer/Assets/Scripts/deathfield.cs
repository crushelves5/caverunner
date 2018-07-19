using System.Collections;
using UnityEngine;

public class deathfield : MonoBehaviour {
    public TimeManager timeManagerScript;
    public GameObject touchControls;
    public GameObject player;
    public GameObject body;
    public GameObject deathParticles;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject== player)
        {
            body.gameObject.SetActive(false);
            deathParticles.SetActive(true);
            touchControls.gameObject.SetActive(false);
            StartCoroutine("waitforseconds");   
        }
    }

        IEnumerator waitforseconds() { 
   
        yield return new WaitForSeconds(1);
        timeManagerScript.endGame();
    }

}
