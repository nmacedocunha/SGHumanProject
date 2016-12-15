using UnityEngine;
using System.Collections;

public class UICanvas : MonoBehaviour {

	// hideUI
	public void hideUI(){
		transform.gameObject.SetActive (false);
	}
}
