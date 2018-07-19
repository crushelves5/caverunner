using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
    public GameObject gameoverscreen;
      int randomNum;
	 public void playAd()
    {
        randomNum = Random.Range(0, 10);
        if (randomNum == 4)
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show();
            }
        }
    }
   
}
