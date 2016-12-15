using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollBarManagement : MonoBehaviour {

	[Header("ScrollBar")]
	public GameObject scrollBarObject;
	public Image somImage;

	[Header("Sprite's")]
	public Sprite somImageMaximo;
	public Sprite somImageMedio;
	public Sprite somImageBaixo;

	// variaveis 

	private Scrollbar scrollBar;

	// Update
	void Update(){
		scrollBar = scrollBarObject.gameObject.GetComponent<Scrollbar> ();

		if (scrollBar.value > 0.75f) {
			somImage.sprite = somImageMaximo;
			Debug.Log ("Volume Maximo");
		} else if((scrollBar.value >= 0.25f) && (scrollBar.value <= 0.75f)){
			somImage.sprite = somImageMedio;
			Debug.Log("Volume Medio");
		} else {
			somImage.sprite = somImageBaixo;
			Debug.Log("Volume baixo");
		}

	}
}
