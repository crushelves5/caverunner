using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class TimeManager : MonoBehaviour {
    public AdManager AdManager;
	public float startingTime;
	public float cautionTime;
	private Text theText;
	public GameObject timer;
	public PlayerControl player;
	private bool timeCheck;
	public GameObject GameOverScreen;
	public GameObject touchControls;
	public Animator caution;
	public GameObject Boulder;
    public GameObject backgroundMusic;

	// Use this for initialization
	void Start () {
		theText = GetComponent<Text>();
		player = FindObjectOfType<PlayerControl> ();
		timeCheck = true;
        Advertisement.Initialize("96234");

    }
	
	// Update is called once per frame
	void Update () {
		if (timeCheck == true ) {
			startingTime -= Time.deltaTime;
			theText.text = ""+Mathf.Round (startingTime);
			if ((startingTime <= cautionTime) && (startingTime > 15)) {
				caution.SetBool("yellow",true);
			}
			if (startingTime <= 15) {
				caution.SetBool("red",true);
			}
		}
		if (startingTime <= 0) {
			timeCheck = false;
            endGame();
		}
		if (startingTime <= 5) {
			Boulder.gameObject.SetActive(true);
		} 
	}

   public void endGame()
    {
        player.gameObject.SetActive(false);
        touchControls.SetActive(false);
        backgroundMusic.SetActive(false);
        timer.SetActive(false);
        AdManager.playAd();
        GameOverScreen.SetActive(true);
       
    
    }


}
	