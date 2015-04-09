using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float timeEllapsed = Time.timeSinceLevelLoad;

		if (timeEllapsed > 7) {
			Destroy (gameObject);
		} else if (timeEllapsed > 5) {
			float alpha = 1 - (timeEllapsed - 5)/2;
			RawImage image = GetComponent<RawImage> ();
			Color color = image.color;
			color.a = alpha;
			image.color = color;
		} else if (timeEllapsed < 1) {
			float alpha = timeEllapsed;
			RawImage image = GetComponent<RawImage> ();
			Color color = image.color;
			color.a = alpha;
			image.color = color;
		}
	}
}
