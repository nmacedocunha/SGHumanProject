using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class head : MonoBehaviour {

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

		textoTitulo = "Crânio";
		texto ="É o termo usado para definir a estrutura rígida, cartilagínosa ou óssea. A função do crânio possui a função de armazenar e proteger o encéfalo, além" +
			"em de proporcionar fixação aos músculos do rosto e da boca.";
	}

	void OnMouseDown(){
		if (!quadro) {
			resumoTexto.text = texto;
			headerText.text = textoTitulo;
			rend.material.color = startColor;
			GameMaster.clone = this.gameObject;
			CameraMovement.gameObjectName = "head";
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
