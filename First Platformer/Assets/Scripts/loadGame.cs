using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour {
    int waitTime;
    public int level;
    // Use this for initialization
    void Start()
    {
        StartCoroutine("WaitThreeSeconds");
      
        level = 1;
       

    }

    IEnumerator WaitThreeSeconds()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(level);
    }

    }
