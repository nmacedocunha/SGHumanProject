using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class bracoDireito : MonoBehaviour {

	[Header("Color")]
	public Color startColor;
	public Color hoverColor;

	[Header("Texto")]
	public Text headerText;
	public Text resumoTexto;

	[Header("Pivo")]
	public Transform partToRotate;

	[Header("Outros")]
	public bool quadro;

	// variaveis 

	private string texto;
	private string textoTitulo;
	private Renderer rend;

	// Awake
	void Awake(){
		
		rend = GetComponent<Renderer> ();
		startColor = rend.material.color;

		textoTitulo = "Rádio";
		texto = "É o osso lateral do antebrçao. Éo mais curto dos dois ossos do antebraço. Articula-se proximalmente com o úmero e a ulna e distalmente com os ossos do carpo e a ulna.";
	}

	void OnMouseDown(){
		if (!quadro) {
			resumoTexto.text = texto;
			headerText.text = textoTitulo;
			rend.material.color = startColor;
			GameMaster.clone = partToRotate.gameObject;
			CameraMovement.gameObjectName = "bracoDireito";
			CameraMovement.escolhido = true;
		}

	}

	void OnMouseEnter(){
		if (!quadro) {
			rend.material.color = hoverColor;
		}
	}

	void OnMouseExit(){
		if (!quadro) {
			rend.material.color = startColor;
		}
	}

	void Update(){
		if (quadro) {
			int speed = 100;
			partToRotate.transform.Rotate (Vector3.up * speed * Time.deltaTime);
		}
	}
}
