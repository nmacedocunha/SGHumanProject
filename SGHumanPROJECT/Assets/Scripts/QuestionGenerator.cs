using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;
using System.Collections;

public class QuestionGenerator : MonoBehaviour {

	// Classe QuadroPergunta
	public class QuadroPergunta
	{
		public string pergunta;
		public string opcaoA;
		public string opcaoB;
		public string opcaoC;
		public string opcaoD;
	}
		
	[Header("Pergunta e Respostas")]

	public Text pergunta;
	public Text opcaoA;
	public Text opcaoB;
	public Text opcaoC;
	public Text opcaoD;

	[Header("Contador")]
	public Text respostasCertas;
	public Text respostasErradas;

	// variaveis

	private int countCertas;
	private int countErradas;
	private int numeroRecebido;
	private int count;
	private int questionNumber;
	private int contador;
	private bool[] qNumber;
	private int[] verificarNumero;
	private QuadroPergunta[] dados;

	private string ficheiro = "perguntas_respostas.txt";
	private string ficheiroRespostas = "respostas_certas.txt";

	public static bool jogoAcabou;

	// Start
	void Start(){
		NewGame ();
	} 

	// Recebe Resposta
	public void recebeResposta(int valor){
		numeroRecebido = valor;
		Debug.Log (numeroRecebido);
	}

	// Verifica Resposta
	public void verificaResposta(){
		if(verificarNumero[questionNumber] == numeroRecebido){	
			countCertas++;
		} else{
			countErradas++;
		}
	}

	// Generate Question
	public void GenerateQuestion(){		
		if (count == (contador - 1)) {
			jogoAcabou = true;
			respostasCertas.text = "Acertou : " + countCertas.ToString();
			respostasErradas.text = "Errou : " + countErradas.ToString();
		} else {
			questionNumber = Mathf.RoundToInt(Random.Range (0, contador));
			getQuestion ();
		}
	
	}

	// Get Question
	void getQuestion(){			
		StreamReader sr = new StreamReader(ficheiro);
		string line;

		for (int i = 0; i < contador; i++) {

			line = sr.ReadLine ();
			string[] linhas = line.Split(',');
			dados[i] = new QuadroPergunta();
			dados [i].pergunta = linhas[0];
			dados [i].opcaoA = linhas[1];
			dados [i].opcaoB = linhas[2];
			dados [i].opcaoC = linhas[3];
			dados [i].opcaoD = linhas[4];
		}

		if (qNumber [questionNumber] == false) {
			pergunta.text = dados [questionNumber].pergunta;
			opcaoA.text = dados [questionNumber].opcaoA;
			opcaoB.text = dados [questionNumber].opcaoB;
			opcaoC.text = dados [questionNumber].opcaoC;
			opcaoD.text = dados [questionNumber].opcaoD;
			qNumber [questionNumber] = true;		
			count = count + 1;
		} else {
			GenerateQuestion ();
		}
	}

	// New Game
	public void NewGame(){
		count = 0;
		countErradas = 0;
		countCertas = 0;

		contador = File.ReadAllLines(ficheiro).Length;

		qNumber = new bool[contador];
		dados = new QuadroPergunta[contador];
		verificarNumero = new int[contador];

		StreamReader sr = new StreamReader(ficheiroRespostas);

		for (int i = 0; i < File.ReadAllLines(ficheiroRespostas).Length; i++) {
			verificarNumero[i] = int.Parse(sr.ReadLine ());
		}

		for (int i = 0; i < contador; i++) {
			qNumber [i] = false;
		}

		GenerateQuestion ();
	}
}

