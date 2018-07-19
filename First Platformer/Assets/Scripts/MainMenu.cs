using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class MainMenu : MonoBehaviour {
	public GameObject loading;
    public Animator levelSelect;
    public int level;
    public int levelVal;
   
	float waitTime;


	public void levelSelectIn()
	{
        levelSelect.SetBool("anim", true);
	}
    public void levelSelectOut()
    {
        levelSelect.SetBool("anim", false);
    }
    public void levelSelector(int level)
    {
        loading.SetActive(true);
        levelVal = level;
       
        SceneManager.LoadScene(levelVal);
    }


   public void quit()
    {
        Application.Quit();
    }
}
