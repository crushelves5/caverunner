using UnityEngine;
using System.Collections;

public class ClearChecker : MonoBehaviour {
    public GameObject checkMark;
    public int level;
    public float ClearOrNot;
	void Start () {
       if( level == 1)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime1");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
        if (level == 2)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime2");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
        if (level == 3)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime3");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
        if (level == 4)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime4");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
        if (level == 5)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime5");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
        if (level == 6)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime6");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
        if (level == 7)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime7");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
        if (level == 8)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime8");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
        if (level == 9)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime9");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
        if (level == 10)
        {
            ClearOrNot = PlayerPrefs.GetFloat("BestTime10");
            if (ClearOrNot > 0)
            {
                checkMark.gameObject.SetActive(true);
            }
        }
    }
	

}
