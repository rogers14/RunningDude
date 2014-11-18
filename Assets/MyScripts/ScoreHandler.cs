using UnityEngine;
using System.Collections;

public class ScoreHandler : MonoBehaviour {

	public int score = 1000;
	public int itemPlaceSubtraction = 10;
	public int deathSubtraction = 5;

	public void itemPlace() {
		score -= itemPlaceSubtraction;
	}

	public void death() {
		score -= deathSubtraction;
	}
}
