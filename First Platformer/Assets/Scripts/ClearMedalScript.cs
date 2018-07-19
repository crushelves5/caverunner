using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClearMedalScript : MonoBehaviour {
	public Sprite bronze;
	public Sprite silver;
	public Sprite gold;
	public LevelClear lvlClearScript;
	public float bronzeTime;
	public float silverTime;
	public Animator anim;
	float levelClearTime;
    public Text medal;
   

	void Start () {
		levelClearTime = lvlClearScript.clearTime;
		anim = GetComponent<Animator> ();
		StartCoroutine (waitTwoSeconds());
       


	if( levelClearTime<=bronzeTime)
		{
			gameObject.GetComponent<Image>().sprite = bronze;
            medal.text = "BRONZE";
		}
		if((levelClearTime>bronzeTime)&&(levelClearTime<silverTime))
		{
			gameObject.GetComponent<Image>().sprite = silver;
            medal.text = "SILVER";
        }
		if(levelClearTime >= silverTime)
		{
			gameObject.GetComponent<Image>().sprite = gold;
            medal.text = "GOLD";
        }
		anim.SetBool("enabled",true);

	}
	IEnumerator waitTwoSeconds()
	{
		yield return new WaitForSeconds(5);
	}
	

}
