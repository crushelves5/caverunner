using UnityEngine;
using System.Collections;

public class getSquashed : MonoBehaviour {
	public GameObject player;
	public bool stopDeducting;
    public TimeManager timeManagerScript;

	void OnTriggerEnter2D(Collider2D col){

		if ((col.gameObject == player.gameObject)&& (stopDeducting = true)) {

			player.transform.localScale = new Vector3(5f,1f,1);
			stopDeducting = false;
            StartCoroutine("WaitThreeSeconds");
            timeManagerScript.GetComponent<TimeManager>().endGame();
		}
	}

    IEnumerator WaitThreeSeconds()
    {
        yield return new WaitForSeconds(2);
    }
    }
