using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class caixaToraxica : MonoBehaviour {

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
	private Renderer rendM;

	// Awake
	void Awake(){
		quadro = false;
		rend = GetComponent<Renderer> ();
		rendM = GameObject.Find ("caixaToraxicaInterior").GetComponent<Renderer> ();
		startColor = rend.material.color;

		textoTitulo = "Caixa Toráxica";
		texto = "A principal função da caixa toráxica é a proteção. Ela forma uma barreira que envolve o coração e os pulmões. O esterno, um dos ossos mais resistentes fica diretamente sobre o coração e é o que mais oferece proteção. A caixa toráxica também serve como uma câmara onde os pulmões podem se expandir para a respiração.";
	}

	void OnMouseDown(){
		if (!quadro) {
			resumoTexto.text = texto;
			headerText.text = textoTitulo;
			rend.material.color = startColor;
			rendM.material.color = startColor;
			GameMaster.clone = this.gameObject;
			CameraMovement.gameObjectName = "caixaToraxica";
			CameraMovement.escolhido = true;
		}

	}

	void OnMouseEnter(){
		if (!quadro) {
			rendM.material.color = hoverColor;
			rend.material.color = hoverColor;
		}
	}

	void OnMouseExit(){
		if (!quadro) {
			rendM.material.color = startColor;
			rend.material.color = startColor;
		}
	}

	void Update(){
		if (quadro) {
			int speed = 100;
			transform.Rotate (Vector3.up * speed * Time.deltaTime, Space.World);
		}
	}
}
