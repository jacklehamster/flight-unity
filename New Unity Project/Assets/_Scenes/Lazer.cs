using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour {

	public Transform explosion;

	int lifetime;
	// Use this for initialization
	void Start () {
		lifetime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (
			transform.position.x, 
			transform.position.y, 
			transform.position.z + Time.deltaTime * 200);
		if (lifetime++ > 20) {
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter( Collision col) {
//		Debug.Log (col.gameObject.name);
		if (col.gameObject.name != "Lazer(Clone)") {
			if(col.gameObject.name.ToLower().IndexOf("rock")<0)
				col.gameObject.transform.position = new Vector3(
					col.gameObject.transform.position.x,
					col.gameObject.transform.position.y,
					col.gameObject.transform.position.z+300
					);
			Instantiate(explosion,transform.position,Quaternion.identity);
			DestroyObject(gameObject);
		}
	}
}
