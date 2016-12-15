using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EsqueletoMovimento : MonoBehaviour {

	private int speed = 1000;

	// Update
	void Update () {
		if (Input.GetMouseButton (0)) {
			transform.Rotate (0, Input.GetAxis ("Mouse X") * speed * Time.deltaTime, 0);
		}
	}
}