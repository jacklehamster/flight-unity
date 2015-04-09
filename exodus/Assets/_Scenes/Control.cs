using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	public Transform ciel;
	public Transform rockA;
	public Transform rockB;
	public Transform rockC;
	public Transform rockD;
	public Transform rockE;
	public Transform treeA;
	public Transform treeB;
	public Transform treeC;
	public Transform treeD;

	public bool gameOver;
	public CanvasGroup group;

	public float timeDestroyed = 0;
	public float baseSpeed = 0;

	static public Control instance;

	// Use this for initialization
	void Start () {
		instance = this;
		for (int z = -150; z <= 150; z+=10) {
			for (int x = -100; x <= 100; x+=10) {
//				GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
//				plane.AddComponent<Rigidbody>();
//				plane.transform.position = new Vector3(x, 0, z);
				Instantiate(ciel,new Vector3(x,0,z),Quaternion.identity);
			}
		}	

		Transform[] rock = new Transform[] {rockA,rockB,rockC,rockD,rockE,treeA,treeB,treeC,treeD};
		for (int i = 0; i<200; i++) {
			Vector2 pos = Random.insideUnitCircle * 100;
			Transform obj = (Transform) Instantiate(
				rock[i%rock.Length],
				new Vector3(
					pos.x,
					i%rock.Length<=4? Random.Range(0,15):0,
					pos.y+500 + i*i/10),
				Quaternion.identity);
			obj.transform.Rotate(0,Random.Range(0,360),0);
		}
		group.alpha = 0;

//		Application.ExternalCall ( "GJAPI_AuthUser", gameObject.name, "MyMethodToCall" );

	}
/*
	public void MyMethodToCall ( string response )
	{
		string[] splittedResponse = response.Split ( ':' );
		string username = splittedResponse [0];
		string usertoken = splittedResponse [1];
		Debug.Log (username);
		Debug.Log (usertoken);
		// Do whatever you want with it.
	}*/

	// Update is called once per frame
	void Update () {
		float t = Time.timeSinceLevelLoad;
		baseSpeed = 30+t/5;
		if (gameOver) {
			Time.timeScale = 0;
			group.alpha = 1;
		}
	}

	public void reset() {
		gameOver = false;
		Time.timeScale = 1;
		group.alpha = 0;
		Application.LoadLevel (0);
	}
}
