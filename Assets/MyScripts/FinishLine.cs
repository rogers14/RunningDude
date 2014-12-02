using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	ScoreHandler sh;
	public GUIText finishText;

	void Start()
	{
		finishText.text = "";
		sh = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ScoreHandler> ();
	}

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player") {
						finishText.text = "You beat the level! Score: " + sh.score;
			if(Application.loadedLevel == 0) {
				NextLevel(1);
			   }
			else if(Application.loadedLevel == 1) {
				NextLevel(2);
			}
			else if(Application.loadedLevel == 2) {
				NextLevel(3);
			}
			else if(Application.loadedLevel == 3) {
				NextLevel(4);
			}
			else if(Application.loadedLevel == 4) {
				NextLevel(5);
			}
			else if(Application.loadedLevel == 5) {
				NextLevel(6);
			}
			else if(Application.loadedLevel == 6) {
				finishText.text = "You win! Score: " + sh.score;
			}
		}
	}

	public void NextLevel(int levelNum) {
		StartCoroutine(ResetCR(levelNum));
	}
	
	IEnumerator ResetCR(int levelNum) {
		finishText.text = "You beat the level! Score: " + sh.score;
		yield return new WaitForSeconds(3);
		Application.LoadLevel (levelNum);
	}
}
