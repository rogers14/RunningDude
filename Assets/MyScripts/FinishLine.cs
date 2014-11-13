using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour {

	public GUIText finishText;

	void Start()
	{
		finishText.text = "";
	}

	void OnTriggerEnter(Collider c)
	{
		finishText.text = "You Win!";
	}
}
