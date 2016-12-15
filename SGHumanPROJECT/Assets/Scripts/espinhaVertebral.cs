using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class espinhaVertebral : MonoBehaviour {

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
		quadro = false;
		rend = GetComponent<Renderer> ();
		startColor = rend.material.color;

		textoTitulo = "Coluna Vertebral";
		texto = "A coluna vertebral está ligada à medula espinhal finalizando-a e protegendo-a. É responsavel pela sustentação da cabeça, fixação das costelas e os músculos do dorso. Suas Curvaturas são responsáveis pela força, sustentação e equilíbrio corporal.";
	}


	void OnMouseDown(){
		if (!quadro) {
			resumoTexto.text = texto;
			headerText.text = textoTitulo;
			rend.material.color = startColor;
			GameMaster.clone = this.gameObject;
			CameraMovement.gameObjectName = "espinhaVertebral";
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
			transform.Rotate (Vector3.up * speed * Time.deltaTime, Space.World);
		}
	}
}
