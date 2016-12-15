using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	
	[Header("Canvas")]
	public Canvas menuResumo;
	public Canvas resumeMenu;

	[Header("Camera")]
	public Transform target;
	public int speed;

	[Header("Instancia")]
	public Transform bonePlacement;

	// variaveis

	private GameObject clone;
	private Vector3 direction;

	public static bool escolhido;
	public static bool goHome;
	public static string gameObjectName;

	// goTo
	void goTo(){		
		transform.Translate (direction.normalized * speed * Time.deltaTime, Space.World);
	}

	// firstPosition
	public void firstPosition(){
		goHome = true;
		target = GameObject.Find ("StartPosition").GetComponent<Transform>();
		transform.Translate (direction.normalized * speed * Time.deltaTime, Space.World);
	}

	// Update
	void Update () {
		direction = target.position - transform.position;

		if(escolhido){
			resumeMenu.gameObject.SetActive (false);
			target = GameObject.Find ("targetCam").GetComponent<Transform>();

			if (Vector3.Distance (target.position, transform.position) <= 0.03f) {				
				escolhido = false;
				menuResumo.gameObject.SetActive (true);

				if(CameraMovement.gameObjectName == "bacia"){
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2.2f;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponent<bacia> ().quadro = true;
				}
				if(CameraMovement.gameObjectName == "bracoDireito"){
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.transform.localScale = new Vector3 (31, 31, 31);
					clone.GetComponentInChildren<bracoDireito>().quadro = true; // found you motherfucker
				}
				if (CameraMovement.gameObjectName == "bracoDireitoSuperior") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<bracoDireitoSuperior>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "bracoEsquerdo") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<bracoEsquerdo>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "bracoEsquerdoSuperior") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<bracoEsquerdoSuperior>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "caixaToraxica") {
					Vector3 posicao;
					posicao.x = 5.938f;
					posicao.y = 1.717f;
					posicao.z = -1.846f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.transform.localScale = new Vector3 (31, 31, 31);
					clone.GetComponent<caixaToraxica> ().quadro = true;
				}
				if (CameraMovement.gameObjectName == "espinhaVertebral") {
					Vector3 posicao;
					posicao.x = 5.965f;
					posicao.y = 1.794f;
					posicao.z = -1.74f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.transform.localScale = new Vector3 (31, 31, 23);
					clone.GetComponent<espinhaVertebral> ().quadro = true;
				}
				if (CameraMovement.gameObjectName == "head") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, bonePlacement.position, bonePlacement.rotation);
					clone.GetComponent<head> ().quadro = true;
				}
				if (CameraMovement.gameObjectName == "leftFoot") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -2.8f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<leftFoot>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "leftLeg") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<leftLeg>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "maoDireita") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<maoDireita>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "maoEsquerda") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<maoEsquerda>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "rightFoot") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -2.8f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<rightFoot>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "rightLeg") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<rightLeg>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "UpperLeftLeg") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<UpperLeftLeg>().quadro = true;
				}
				if (CameraMovement.gameObjectName == "UpperRightLeg") {
					Vector3 posicao;
					posicao.x = 6;
					posicao.y = 2;
					posicao.z = -1.55f;
					clone = (GameObject)Instantiate (GameMaster.clone, posicao, bonePlacement.rotation);
					clone.GetComponentInChildren<UpperRightLeg>().quadro = true;
				}

			} else {
				goTo ();
			}		

		}

		if (goHome) {
			if (Vector3.Distance (target.position, transform.position) <= 0.03f) {
				goHome = false;
				resumeMenu.gameObject.SetActive (true);
			} else {
				firstPosition ();
			}
		}
	}

	// DestroyClone
	public void DestroyClone(){
		Destroy (clone);
	}
}
