using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeEllapsed : MonoBehaviour {

	public Control controller;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Text guiText = (Text)GetComponent<Text> ();
		guiText.text = Time.timeSinceLevelLoad<6 ? "" : (controller.timeDestroyed != 0 ? controller.timeDestroyed : Time.timeSinceLevelLoad).ToString ("F2") + "s";
		if (controller.gameOver && name!="FinalScore") {
			Destroy(gameObject);
		}
	}
}
