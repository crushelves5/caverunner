using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnlockLevels : MonoBehaviour {
    public int levelNumber;
    public GameObject lockIcon;
    public GameObject button;
    float time;
	// Use this for initialization

	
	void Update () {
        if (levelNumber == 4)
        {
            time = PlayerPrefs.GetFloat("BestTime3");
            if (time > 0)
            {
                lockIcon.gameObject.SetActive(false);
                button.GetComponent<Button>().interactable = true;
            }
        }
        if (levelNumber == 5)
        {
            time = PlayerPrefs.GetFloat("BestTime4");
            if (time > 0)
            {
                lockIcon.gameObject.SetActive(false);
                button.GetComponent<Button>().interactable = true;
            }
        }
        if (levelNumber == 6)
        {
            time = PlayerPrefs.GetFloat("BestTime5");
            if (time > 0)
            {
                lockIcon.gameObject.SetActive(false);
                button.GetComponent<Button>().interactable = true;
            }
        }
        if (levelNumber == 7)
        {
            time = PlayerPrefs.GetFloat("BestTime6");
            if (time > 0)
            {
                lockIcon.gameObject.SetActive(false);
                button.GetComponent<Button>().interactable = true;
            }
        }
        if (levelNumber == 8)
        {
            time = PlayerPrefs.GetFloat("BestTime7");
            if (time > 0)
            {
                lockIcon.gameObject.SetActive(false);
                button.GetComponent<Button>().interactable = true;
            }
        }
        if (levelNumber == 9)
        {
            time = PlayerPrefs.GetFloat("BestTime8");
            if (time > 0)
            {
                lockIcon.gameObject.SetActive(false);
                button.GetComponent<Button>().interactable = true;
            }
        }
        if (levelNumber == 10)
        {
            time = PlayerPrefs.GetFloat("BestTime9");
            if (time > 0)
            {
                lockIcon.gameObject.SetActive(false);
                button.GetComponent<Button>().interactable = true;
            }
        }
    }
}
