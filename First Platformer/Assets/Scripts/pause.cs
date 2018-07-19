using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

	public GameObject pauseScreen;
	public GameObject touchControls;

	public void pauser()
	{
		touchControls.SetActive (false);
		Time.timeScale = 0.0f;
		pauseScreen.SetActive (true);
	}
	public void player()
	{
		touchControls.SetActive (true);
		pauseScreen.SetActive (false);
		Time.timeScale = 1f;
	}
}
