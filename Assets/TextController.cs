using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text texto;

	// Use this for initialization
	void Start () {
		texto.text = "Bem vindo ao Prison World!\n" +
		" Aperte Espaço para Iniciar.";

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			texto.text = "Você esta em uma cela da Prisão, e quer escapar." +
				"você vê alguns lençois sujos na cama, um espelho na parede e uma porta," +
				" ela parece estar fechada pelo lado de fora.\n\n" +
				"Aperte L para verificar os Lençois\n" +
				"Aperte E para verificar o Espelho\n" +
				"Aperte P para verificar a Porta";
		}
	}
}
