using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class rightLeg : MonoBehaviour {

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

		textoTitulo = "Fíbula / Tíbia";
		texto = "Exeto pelo fémur, a tíbia é o maior osso no corpo que suporta o peso. Está localizada no lado ântero-medial da perna. Apresenta duas epífises e uma diáfise. Articula-se proximalmente com o fémur e fíbula e distalmente com o tálus e a fíbula";
	}

	void OnMouseDown(){
		if (!quadro) {
			resumoTexto.text = texto;
			headerText.text = textoTitulo;
			rend.material.color = startColor;
			GameMaster.clone = partToRotate.gameObject;
			CameraMovement.gameObjectName = "rightLeg";
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
			partToRotate.transform.Rotate (Vector3.up * speed * Time.deltaTime );
		}
	}
}
