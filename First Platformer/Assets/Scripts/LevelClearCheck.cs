using UnityEngine;
using System.Collections;

public class LevelClearCheck : MonoBehaviour {

    public int level;
    public GameObject levelclearscreen;
    public float levelClearorNot;
    public float bestTime;
	void Update () {

	if(level == 1)
        {
             PlayerPrefs.GetFloat("levelClear1");
            bestTime = PlayerPrefs.GetFloat("BestTime1");
            if (bestTime > 0)
            {
                levelClearorNot = 1;
                PlayerPrefs.SetFloat("levelclear1", levelClearorNot);
            }
        }
        if (level == 2)
        {
            PlayerPrefs.GetFloat("levelClear2");
            bestTime = PlayerPrefs.GetFloat("BestTime2");
            if (bestTime > 0)
            {
                levelClearorNot = 1;
                PlayerPrefs.SetFloat("levelclear2", levelClearorNot);
            }
        }
        if (level == 3)
        {
            PlayerPrefs.GetFloat("levelClear3");
            bestTime = PlayerPrefs.GetFloat("BestTime3");
            if (bestTime > 0)
            {
                levelClearorNot = 1;
                PlayerPrefs.SetFloat("levelclear3", levelClearorNot);
            }
        }
        if (level == 4)
        {
            PlayerPrefs.GetFloat("levelClear4");
            bestTime = PlayerPrefs.GetFloat("BestTime4");
            if (bestTime > 0)
            {
                levelClearorNot = 1;
                PlayerPrefs.SetFloat("levelclear4", levelClearorNot);
            }
        }
        if (level == 5)
        {
            PlayerPrefs.GetFloat("levelClear5");
            bestTime = PlayerPrefs.GetFloat("BestTime5");
            if (bestTime > 0)
            {
                levelClearorNot = 1;
                PlayerPrefs.SetFloat("levelclear5", levelClearorNot);
            }
        }

    }
}
