using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public string startLevel;

public void restart()
	{
		SceneManager.LoadScene(startLevel);
		Time.timeScale = 1f;
	}
}