using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	ScoreHandler sh;
	public GUIText finishText;
	public AudioSource sound;
	private GameObject player;
	private Animation animation;
	private MoveCharacter moveScript;
	public AnimationClip dance;


	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		animation = player.GetComponent<Animation> ();
		moveScript = player.GetComponent<MoveCharacter> ();
		finishText.text = "";
		sh = GameObject.FindGameObjectWithTag ("GameController").GetComponent<ScoreHandler> ();
	}

	void OnTriggerEnter(Collider c)
	{
		sound.Play();
		if (c.tag == "Player") {
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
		moveScript.player.transform.rotation = Quaternion.AngleAxis(90, Vector3.up) * moveScript.player.transform.rotation;
		moveScript.enabled = false;
		animation.Play (dance.name);
		finishText.text = "You beat the level! Score: " + sh.score;
		yield return new WaitForSeconds(3);
		Application.LoadLevel (levelNum);
	}
}
