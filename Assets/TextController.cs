using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text texto;

	private enum Estados{cela,espelho,lencol_0,fechadura_0,espelho_cela,lencol_1,fechadura_1,liberdade,
		corredor_0,corredor_1,corredor_2,corredor_3,escada_0,escada_1,escada_2,fundos,chao,armarioFechado,armarioAberto};
	private Estados meuEstado;

	// Use this for initialization
	void Start () {
		//texto.text = "Bem vindo ao Prison World!\n" +
		//" Aperte Espaço para Iniciar.";
		meuEstado = Estados.cela;
	}

	// Update is called once per frame
	void Update () {
		
		if 		(meuEstado == Estados.cela) 			{cela ();	}
		else if (meuEstado == Estados.lencol_0) 		{lencol_0 ();}
		else if (meuEstado == Estados.lencol_1) 		{lencol_1 ();}
		else if (meuEstado == Estados.fechadura_0) 		{fechadura_0 ();} 
		else if (meuEstado == Estados.fechadura_1) 		{fechadura_1 ();} 
		else if (meuEstado == Estados.espelho)			{espelho_0 ();} 
		else if (meuEstado == Estados.espelho_cela) 	{espelho_cela ();} 
		else if (meuEstado == Estados.corredor_0) 		{corredor_0 ();}
		else if (meuEstado == Estados.corredor_1) 		{corredor_1 ();}
		else if (meuEstado == Estados.corredor_2) 		{corredor_2 ();}
		else if (meuEstado == Estados.corredor_3) 		{corredor_3 ();}
		else if (meuEstado == Estados.escada_0) 		{escada_0 ();}
		else if (meuEstado == Estados.escada_1) 		{escada_1 ();}
		else if (meuEstado == Estados.escada_2) 		{escada_2();}
		else if (meuEstado == Estados.fundos) 			{fundos ();}
		else if (meuEstado == Estados.chao) 			{chao ();}
		else if (meuEstado == Estados.armarioFechado)	{armarioFechado();}
		else if (meuEstado == Estados.armarioAberto) 	{armarioAberto ();}
	}



	void cela(){
		texto.text = "Você esta em uma cela da Prisão, e quer escapar." +
			"você vê alguns lençois sujos na cama, um espelho na parede e uma porta," +
			" ela parece estar fechada pelo lado de fora.\n\n" +
			"Aperte L para verificar os Lençois\n" +
			"Aperte E para verificar o Espelho\n" +
			"Aperte F para verificar a Fechadura";
		if 		(Input.GetKeyDown (KeyCode.L))	 	{meuEstado = Estados.lencol_0;}
		else if (Input.GetKeyDown (KeyCode.E)) 		{meuEstado = Estados.espelho;}
		else if (Input.GetKeyDown(KeyCode.F))		{meuEstado = Estados.fechadura_0;
		}
	}

		void espelho_0 (){
			texto.text = "um espelho velho e sujo,ele parece estar solto.\n\n"+
				"Aperte P para Pegar o Espelho, ou V para voltar a Cela";
			if 		(Input.GetKeyDown(KeyCode.P))			{meuEstado = Estados.espelho_cela;}
			else if (Input.GetKeyDown(KeyCode.V))			{meuEstado = Estados.cela;}
			
		}

	void espelho_cela(){
		texto.text = "Você continua na cela, e continua querendo escapar, dentro de cela voce encontra, "+
					  "alguns lencois sujos na cama, a marca de onde o espelho estava.\n\n" +
					  "Aperte L para ver os lencois, ou F para ver a Fechadura ";

		if 		(Input.GetKeyDown (KeyCode.L)) 		{meuEstado = Estados.lencol_1;} 	
		else if (Input.GetKeyDown (KeyCode.F)) 		{meuEstado = Estados.fechadura_1;}
	}


	void lencol_0(){
		texto.text = "Você nao acredita que dormia nessa coisa.ja esta na hora de alguem troca-lo, " +
					 "os prazeres da vida na prisão, eu acho.\n\n" +
					 "Aperte V para voltar a o centro da cela";
		
		if (Input.GetKeyDown (KeyCode.V)) {meuEstado = Estados.cela;}

	}

	void lencol_1(){
		texto.text = 	"segurando um espelho na mão, nao faz os lencois parecerem nem um pouco melhor, " +
						"\n\n" +
						"Aperte V para voltar a o centro da cela";
		
		if (Input.GetKeyDown (KeyCode.V)) {meuEstado = Estados.espelho_cela;}
	}

	void fechadura_0(){
		texto.text = "Esta é uma daquelas fechaduras com senha de codigos, Você nao tem a menor ideia de qual é o codigo" +
					" Você tenta ver a marca da sujeira e das digitais no teclado, talvez isso ajude.\n\n"+
					" Aperte V para voltar ao centro da cela";
					
		if (Input.GetKeyDown (KeyCode.V)) {meuEstado = Estados.cela;}

	}

	void fechadura_1(){
		texto.text = "Você cuidadosamente coloca o espelho entre as barras, e gira o espelho, dessa maneira " +
					"você é capaz de ver o teclado da fechadura. você aperta as teclas que estão sujos e escuta um clique!\n\n" +
					"Aperte A para Abrir, ou V para volta ao centro da cela.";

		if 		(Input.GetKeyDown (KeyCode.V)) 	{meuEstado = Estados.espelho_cela;} 
		else if (Input.GetKeyDown (KeyCode.A)) 	{meuEstado = Estados.corredor_0;}
	}
	void corredor_0 (){
		texto.text = "Agora Você esta fora da cela, mas nao fora de perigo," +
					" Você se encontra no corredor. Você vê uma armario e uma escada que leva para o jardim dos fundos" +
					" e tambem tem variaos objetos espalhados pelo chao.\n\n" +
					  " Aperte A para olhar o armario,\n Aperte O para observar o andar, \n Aperte S para subir as escadas.";

		if 		(Input.GetKeyDown (KeyCode.A)) 	{meuEstado = Estados.armarioFechado;} 
		else if (Input.GetKeyDown (KeyCode.S)) 	{meuEstado = Estados.escada_0;}
		else if (Input.GetKeyDown (KeyCode.O)) 	{meuEstado = Estados.chao;}
	}

	void corredor_1(){
		texto.text = "Você continua no corredor,  o chao ainda esta sujo, carrega clipe na mão, e agora?" +
					" Você se pergunta se consiguiria Abrir o armario com o clipe.\n\n" +
					"Aperte A para tentar abrir o armario, ou S para subir as escadas.";

		if 		(Input.GetKeyDown (KeyCode.A)) 	{meuEstado = Estados.armarioAberto;} 
		else if (Input.GetKeyDown (KeyCode.S)) 	{meuEstado = Estados.escada_1;}
	}

	void corredor_2(){
		texto.text = "De volta ao corredor, tendo negado-se a vestir a roupa do zelador.\n\n" +
					"Aperte R para revistar o armario novamente, ou S para subir as escadas.";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{meuEstado = Estados.armarioAberto;} 
		else if (Input.GetKeyDown (KeyCode.S)) 	{meuEstado = Estados.escada_2;}
		
	}

	void corredor_3(){
		texto.text = "De volta ao corredor, Agora vistido de zelador." +
					"Você considera fortemente que é Capaz de fugir agora.\n\n" +
					"Aperte R para retirar a roupa de zelador, ou S para subir as escadas.";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{meuEstado = Estados.corredor_2;} 
		else if (Input.GetKeyDown (KeyCode.S)) 	{meuEstado = Estados.fundos;}

	}
	void armarioFechado(){
		texto.text = " Você esta olhado para um armario, mas, infelizmente ele esta trancado." +
						" Talvez você encontre alguma coisa para ajudar a Abrir.\n\n" +
						"Aperte V para voltar ao corredor.";
		
		if (Input.GetKeyDown (KeyCode.V)) 	{meuEstado = Estados.corredor_0;}

	}

	void armarioAberto(){
		texto.text = " Dentro do armario Você encontra um uniforme de zelador, aproximadamente do seu tamanho " +
						"Parece que é seu dia de sorte.\n\n" +
						"Aperte Z para vestir a ropua de zelador, ou V para voltar ao corredor";
						
		if (Input.GetKeyDown (KeyCode.V)) 	{meuEstado = Estados.corredor_2;}
		if (Input.GetKeyDown (KeyCode.Z)) 	{meuEstado = Estados.corredor_3;}
	}
	void chao(){
		texto.text = " revirando o andar, Você encontra um clipe de cabelo no chão.\n\n" +
						"Aperte P para pegar o clipe, ou V para voltar para o corredor.";

		if 		(Input.GetKeyDown (KeyCode.P)) 	{meuEstado = Estados.corredor_1;}
		else if (Input.GetKeyDown (KeyCode.V)) 	{meuEstado = Estados.corredor_0;}
	}
	void escada_0(){
		texto.text = "Você comeca a subir as escadas e percebe que ainda não esta na hora de sair " +
					"pois sera pego imediatamente. Você desce as escadas cautelosamente e reconsidera.\n\n" +
					"Aperte V para voltar ao corredor.";

		if (Input.GetKeyDown (KeyCode.V)) 		{meuEstado = Estados.corredor_0;}
	}

	void escada_1(){
		texto.text = " Infelizmente carregando apenas um pequeno clip de cabelo, não lhe deu confianca para sair pelo jardim dos fundos" +
					" da prisão vigiada por guardas armados\n\n" +
					"Aperte V para volta ao corredor";

		if (Input.GetKeyDown(KeyCode.V))			{meuEstado = Estados.corredor_1;}
	}

	void escada_2(){
		texto.text = "Você sente-se confiante por ter conseguido abrir a porta com o clipe, " +
					"Você ainda carrega o clipe(agora muito curvado). Mesmo com todas essas realizações nao lhe dao coragem para" +
					"para subir as escadas e enfrentar a morte.\n\n" +
					"Aperte V para volta ao corredor";

		if (Input.GetKeyDown(KeyCode.V))			{meuEstado = Estados.corredor_2;}
	}

	void fundos(){
		texto.text = " Você começa a Atravessar pelo jardim dos fundos vestido como um zelador." +
					" os guardas comprimentam você  balançando a cabeca, enquanto você caminha para a liberdade." +
					" seu coração acelera a medida em que você se aproxima da saida" +
					" finalmente você conseguiu sair e caminha livre com apenas o por do sol a sua frente.\n\n" +
					" Aperte J para jogar novemente";

		if (Input.GetKeyDown (KeyCode.J)) {meuEstado = Estados.cela;}
	}

	void liberdade(){
		texto.text = "Parabens Você esta livre\n\n" +
					"Aperte J para jogar outra vez";
		if(Input.GetKeyDown(KeyCode.J)){
			meuEstado = Estados.cela;
		}

	
	}
}
