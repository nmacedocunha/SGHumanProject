using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMaster : MonoBehaviour {
	
	[Header("Cameras")]
	public Camera mainCamera;
	public Camera resumosCamera;

	[Header("Canvas")]

	public Canvas resumeMenu;
	public Canvas instrucoesMenu;
	public Canvas menuJogo;
	public Canvas menuJogoFim;
	public Canvas definicoesMenu;
	public Canvas fichaTecnicaMenu;

	// variaveis
	private Canvas mainMenu;
	public static GameObject clone;

	// Awake
	void Awake(){
		mainMenu = GameObject.Find ("MainMenuCanvas").GetComponent<Canvas> ();
	}

	// Resumos Option
	public void ResumosOption(){
		resumeMenu.gameObject.SetActive (true);
		mainMenu.gameObject.SetActive (false);
		mainCamera.gameObject.SetActive (false);
		resumosCamera.gameObject.SetActive (true);
	}

	// Main Menu Option
	public void MainMenuOption(){
		resumeMenu.gameObject.SetActive (false);
		mainMenu.gameObject.SetActive (true);
		mainCamera.gameObject.SetActive (true);
		resumosCamera.gameObject.SetActive (false);
	}

	// Quit Game
	public void QuitGame(){
		Application.Quit ();
	}

	// Instruções Option
	public void InstrucoesOption(){
		mainMenu.gameObject.SetActive (false);
		instrucoesMenu.gameObject.SetActive (true);
	}

	// Exit Instruções Option
	public void ExitInstrucoesOption(){
		mainMenu.gameObject.SetActive (true);
		instrucoesMenu.gameObject.SetActive (false);
	}

	// GameStart
	public void GameStart(){
		mainMenu.gameObject.SetActive (false);
		menuJogo.gameObject.SetActive (true);
	}

	// Update
	void Update(){
		if (QuestionGenerator.jogoAcabou) {
			menuJogo.gameObject.SetActive (false);
			menuJogoFim.gameObject.SetActive (true);
		}
	}

	// GameIsOver
	public void GameIsOver(){
		menuJogoFim.gameObject.SetActive (false);
		mainMenu.gameObject.SetActive (true);
		QuestionGenerator.jogoAcabou = false;
	}

	// Exit Definições
	public void ExitDefinicoes(){
		definicoesMenu.gameObject.SetActive (false);
		mainMenu.gameObject.SetActive (true);
	}

	// Definições Option
	public void definicoesOption(){
		definicoesMenu.gameObject.SetActive (true);
		mainMenu.gameObject.SetActive (false);
	}

	// Ficha Técnica
	public void FichaTecnica(){
		mainMenu.gameObject.SetActive (false);
		fichaTecnicaMenu.gameObject.SetActive (true);
	}

	// Exit Ficha Técnica
	public void exitFichaTenica(){
		fichaTecnicaMenu.gameObject.SetActive (false);
		mainMenu.gameObject.SetActive (true);
	}
}
