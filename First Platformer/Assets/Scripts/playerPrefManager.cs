using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerPrefManager : MonoBehaviour {
    public LevelClear levelClearScript;
    public float oneTime;
    public float bestTime;
    public Text textBestTime;
    public float howLongIttook;
    public float tempTimeStorage;
    public int level;
   
	// Use this for initialization
	//void Start () {
     //   tempTimeStorage = levelClearScript.howLongItTook;
     //   howLongIttook = Mathf.Round(tempTimeStorage * 100) / 100;
     //   PlayerPrefs.GetFloat("bestTime");
     //   bestTime = PlayerPrefs.GetFloat("bestTime");
    
 //   }
	
	// Update is called once per frame
	void Update () {
        tempTimeStorage = levelClearScript.howLongItTook;
        howLongIttook = Mathf.Round(tempTimeStorage * 100) / 100;
        if (level == 1)
        {
            PlayerPrefs.GetFloat("BestTIme1");
            bestTime = PlayerPrefs.GetFloat("BestTIme1");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTIme1", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTIme1", howLongIttook);
            }
        }
        if (level == 2)
        {
            PlayerPrefs.GetFloat("BestTime2");
            bestTime = PlayerPrefs.GetFloat("BestTime2");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime2", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime2", howLongIttook);
            }
        }

        if (level == 3)
        {
            PlayerPrefs.GetFloat("BestTime3");
            bestTime = PlayerPrefs.GetFloat("BestTime3");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime3", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime3", howLongIttook);
            }
        }
        if (level == 4)
        {
            PlayerPrefs.GetFloat("BestTime4");
            bestTime = PlayerPrefs.GetFloat("BestTime4");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime4", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime4", howLongIttook);
            }
        }
       
        if (level == 5)
        {
            PlayerPrefs.GetFloat("BestTime5");
            bestTime = PlayerPrefs.GetFloat("BestTime5");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime5", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime5", howLongIttook);
            }
        }
        /////////////////////////////////////////////////////////////////// Every Five levels
        if (level == 6)
        {
            PlayerPrefs.GetFloat("BestTime6");
            bestTime = PlayerPrefs.GetFloat("BestTime6");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime6", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime6", howLongIttook);
            }
        }
        if (level == 7)
        {
            PlayerPrefs.GetFloat("BestTime7");
            bestTime = PlayerPrefs.GetFloat("BestTime7");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime7", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime7", howLongIttook);
            }
        }
        if (level == 8)
        {
            PlayerPrefs.GetFloat("BestTime8");
            bestTime = PlayerPrefs.GetFloat("BestTime8");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime8", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime8", howLongIttook);
            }
        }
        if (level == 9)
        {
            PlayerPrefs.GetFloat("BestTime9");
            bestTime = PlayerPrefs.GetFloat("BestTime9");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime9", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime9", howLongIttook);
            }
        }
        if (level == 10)
        {
            PlayerPrefs.GetFloat("BestTime10");
            bestTime = PlayerPrefs.GetFloat("BestTime10");
            textBestTime.text = "" + bestTime + "s";

            if (bestTime == 0)
            {
                bestTime += howLongIttook;
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime10", howLongIttook);
            }
            if (bestTime > howLongIttook)
            {
                textBestTime.text = "" + bestTime + "s";
                PlayerPrefs.SetFloat("BestTime10", howLongIttook);
            }
        }
    }

}
