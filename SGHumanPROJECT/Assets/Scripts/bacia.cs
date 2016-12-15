using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class bacia : MonoBehaviour {
	
	[Header("Color")]
	public Color startColor;
	public Color hoverColor;

	[Header("Texto")]
	public Text headerText;
	public Text resumoTexto;

	[Header("Outros")]
	public bool quadro;

	// variaveis 

	private string texto;
	private string textoTitulo;
	private Renderer rend;
	private int speed = 100;

	// Awake
	void Awake(){
		
		quadro = false;
		rend = GetComponent<Renderer> ();
		startColor = rend.material.color;

		textoTitulo = "Quadríl";
		texto = "É uma articulação do tipo esférica formada pela cabeça do fêmur e a cavídade do acetábulo.";
	}

	void OnMouseDown(){
		
		if (!quadro) {
			resumoTexto.text = texto;
			headerText.text = textoTitulo;
			rend.material.color = startColor;

			GameMaster.clone = this.gameObject;
			CameraMovement.escolhido = true;
			CameraMovement.gameObjectName = "bacia";
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
			transform.Rotate (Vector3.up * speed * Time.deltaTime, Space.World);
		}
	}
}
