using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelClear : MonoBehaviour {
	public float clearTime;
	public GameObject player;
	public GameObject counter;
	public GameObject LevelClearScreen;
	public GameObject touchControls;
	public TimeManager tManagerScript;
    public Text yourTime;
    public float maxTime;
    public float howLongItTook;



	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject == player.gameObject) {
			player.gameObject.SetActive (false);
			counter.gameObject.SetActive (false);
			touchControls.SetActive (false);
			clearTime = tManagerScript.startingTime;
            howLongItTook = maxTime - clearTime;
            yourTime.text = "" + Mathf.Round(howLongItTook * 100) / 100 + "s";
			LevelClearScreen.SetActive (true);
		}
	}


}
