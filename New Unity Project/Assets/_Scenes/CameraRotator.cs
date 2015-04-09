using UnityEngine;
using System.Collections;

public class CameraRotator : MonoBehaviour {


	public Control controller;
	// Use this for initialization
	void Start () {
	
//		transform.Rotate (new Vector3(25,0,0));	//	TUTORIAL 6
	}
	
	// Update is called once per frame
	void Update () {
//		Debug.Log (Input.GetAxis("Mouse X")+","+ Input.GetAxis("Mouse Y"));	//	TUTORIAL 7
		//	TUTORIAL 5
//		transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f/10);	


		//	TUTORIAL 8
//		transform.Rotate (new Vector3 (Input.GetAxis ("Mouse Y"),Input.GetAxis("Mouse X"),0));
//		transform.Rotate (new Vector3(0,0,1));
		//Debug.Log (Input.GetAxis ("Mouse Y"));

		//	TUTORIAL 9
//		Debug.Log (Input.mousePosition.x/Screen.width+","+Input.mousePosition.y/Screen.height);
		float mY = Input.mousePosition.y / Screen.height - 0.5f;
		float mX = Input.mousePosition.x / Screen.width - 0.5f;
//		transform.Translate(new Vector3(0,0.01f,0));
//		transform.Rotate (new Vector3(0,mX,0));
//		transform.Rotate (new Vector3(0,0,mX));
		if(!controller.gameOver)
			transform.rotation =Quaternion.Euler(new Vector3 (-mY*10, mX*30, mX*30));
		//		Debug.Log (transform.rotation.eulerAngles);
//		Debug.Log (Camera.main.transform.rotation.y);
	}
}
