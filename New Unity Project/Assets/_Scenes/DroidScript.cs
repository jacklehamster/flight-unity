using UnityEngine;
using System.Collections;

public class DroidScript : MonoBehaviour {

	public Transform lazer;
	public Transform explosion;
	public Control controller;

	Quaternion orgRotation;
	bool firing;
	int charge;
	// Use this for initialization
	void Start () {
		orgRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		float mY = Input.mousePosition.y / Screen.height - 0.5f;
		float mX = Input.mousePosition.x / Screen.width - 0.5f;
		transform.position = new Vector3 (mX * 50, Mathf.Max(1,mY * 10+7), transform.position.z + (2-transform.position.z)/20);
		transform.rotation = Quaternion.RotateTowards (transform.rotation, orgRotation, 1);

		if (Input.GetMouseButtonDown (0) || Input.GetKeyDown(KeyCode.Space)) {
			firing = true;
		} else if (Input.GetMouseButtonUp (0) || Input.GetKeyUp(KeyCode.Space)) {
			firing = false;
		}


		if (firing && charge<40) {
			charge+=4;
			Transform l = (Transform)Instantiate (lazer, transform.position, Quaternion.identity);
			l.transform.Translate (Random.insideUnitSphere);
			l.transform.Translate (0, 0, 15);
			l.transform.rotation = Quaternion.Euler (new Vector3 (90, 0, 0));
		} else {
			charge--;
		}
	}

	void OnCollisionEnter( Collision col) {
		if (true) {
			controller.timeDestroyed = Time.timeSinceLevelLoad;
			Instantiate(explosion,transform.position,Quaternion.identity);
			DestroyObject(gameObject);

			System.Timers.Timer timer = new System.Timers.Timer(4000);
			timer.Elapsed += (source, e) =>
			{
				(controller as Control).gameOver = true;
				Debug.Log((controller as Control).gameOver);
			};
			
			timer.AutoReset = false;
			timer.Enabled = true;
			timer.Start();

		}
	}

}
