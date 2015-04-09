using UnityEngine;
using System.Collections;

public class CielScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		Debug.Log("I am alive!");	//	TUTORIAL 1
//		gameObject.SetActive (false);
//		GetComponent(MeshRenderer).enabled = false;
//		this.gameObject.
//		GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		float speed = Control.instance.baseSpeed;

//		gameObject.SetActive (true);
		float mY = Input.mousePosition.y / Screen.height - 0.5f;
		float mX = Input.mousePosition.x / Screen.width - 0.5f;
		transform.position = new Vector3 (
			transform.position.x - Time.deltaTime * mX * 100, 
			transform.position.y, 
			transform.position.z - Time.deltaTime * speed);
//		transform.Translate(Vector3.back * Time.deltaTime*20);	//	TUTORIAL 2
//		transform.Translate (Vector3.left * Time.deltaTime * mX*100);
//		transform.forward
//		transform.Trans

		//	TUTORIAL 10
//		float angle = Camera.main.transform.rotation.eulerAngles.y* Mathf.PI/180;
//		float dx = Mathf.Sin (angle)* Time.deltaTime*20;
//		float dz = Mathf.Cos (angle)* Time.deltaTime*20;
//		float newX = transform.position.x - dx;
//		float newZ = transform.position.z - dz;
//		Debug.Log (dx+","+dz);

//		newZ = newZ < -100 ? newZ + 200 : 
//			newZ>100 ? newZ - 200 : newZ;
//		newX = newX < -100 ? newX + 200 :
//			newX>100 ? newX - 200 : newX;
//		transform.position = new Vector3 (newX, transform.position.y, newZ);
//		Quaternion rotation = Camera.main.transform.rotation;
//		transform.Translate (new Vector3 (rotation.eulerAngles.x, 0, rotation.eulerAngles.z));

		if (transform.position.z < -150)		//	TUTORIAL 3
			transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+300);
		if (transform.position.x < -100)		//	TUTORIAL 3
			transform.position = new Vector3 (transform.position.x + 200, transform.position.y, transform.position.z);
		else if (transform.position.x > 100) {
			transform.position = new Vector3 (transform.position.x - 200, transform.position.y, transform.position.z);
			//GetComponent<Renderer>().enabled = true;
		}
		//		else if(transform.position.z > 100)
//			transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z-200);
	}
}
