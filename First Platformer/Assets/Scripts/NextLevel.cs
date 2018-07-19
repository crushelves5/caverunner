using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public int Level;
    public GameObject loading;

    public void nextLevel()
    {
        loading.gameObject.SetActive(true);
       SceneManager.LoadScene(Level);
    }
}
