using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {
	public string menuBack;
	public GameObject loading;
public void exit()
	{
		loading.gameObject.SetActive (true);
		SceneManager.LoadScene(menuBack);
	}

	}
