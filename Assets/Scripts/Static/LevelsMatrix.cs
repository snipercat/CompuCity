using UnityEngine;
using System.Collections;

public static class LevelsMatrix {

	private static int[,] l1_secuence = { {1,2}, //Correcto
		{1,0},//1 - Voltimetro
		{0,1},//2 - Cargador
		{1,1},//3 - Memoria
		{0,0},//4 - Disco Duro
		{0,0},//5 - Bateria
		{0,0},//6 - Destornillador
		{0,0},//7 - Soplador
		{0,0},//8 - Antivirus
		{0,0},//9 - Sistema
		{0,0}//10 - Programas
	};

	private static string[,] l1_message = {{"Debo medir la electricidad","Al parecer la fuente de energía no funciona","¡El computador ya funciona!"}, 
		{"Esto no arregla el problema","Esto no arregla el problema",""}};
	/// <summary>
	/// ////////////////////////////////////////
	/// </summary>
	private static int[,] l2_secuence = {  {8,6,7,6}, //Correcto
		{0,0,0,0},//1 - Voltimetro
		{0,0,0,0},//2 - Cargador
		{0,0,1,1},//3 - Memoria
		{1,0,0,0},//4 - Disco Duro
		{0,0,0,0},//5 - Bateria
		{1,1,1,1},//6 - Destornillador
		{1,1,1,1},//7 - Soplador
		{1,0,0,0},//8 - Antivirus
		{0,0,0,0},//9 - Sistema
		{0,0,0,0}//10 - Programas
	};

	private static string[,] l2_message = {{"Seguramente el PC tiene virus","Ya no tiene Virus, pero ¿Cómo quieren que sea rápido si está sucio?","Ahora si lo puedo limpiar","Falta algo más para entregarlo","¡Ya puedo entregarlo!"}, 
		{"Esto no arregla el problema"  ,"No lo puedo limpiar si está sellado","Aún no lo he limpiado","No debo hacerle más cambios",""}};

	/// <summary>
	/// ////////////////////////////////////////
	/// </summary>
	private static int[,] l3_secuence = {  {	4	,	9	,	8	}	,	 //Correcto
		{	0	,	0	,	0	}	,	//1 - Voltimetro
		{	0	,	0	,	0	}	,	//2 - Cargador
		{	0	,	0	,	0	}	,	//3 - Memoria
		{	1	,	1	,	1	}	,	//4 - Disco Duro
		{	0	,	0	,	0	}	,	//5 - Bateria
		{	0	,	0	,	0	}	,	//6 - Destornillador
		{	0	,	0	,	0	}	,	//7 - Soplador
		{	1	,	1	,	1	}	,	//8 - Antivirus
		{	1	,	1	,	1	}	,	//9 - Sistema
		{	1	,	1	,	1	}		//10 - Programas

	};

	private static string[,] l3_message = {{"Antes de Formatear, debo realizar un BackUp","Ahora si puedo formatear"   ,"debo protegerlo de los virus","¡Ya puedo entregarlo!"}, 
		{"Esto no arregla el problema"  			  ,"Esto no arregla el problema","Esto no arregla el problema" ,""}};

	/// <summary>
	/// ////////////////////////////////////////
	/// </summary>
	private static int[,] l4_secuence = {  {	6	,	7	,	3	,	6	}	,	 //Correcto
		{	0	,	0	,	0	,	0	}	,	//1 - Voltimetro
		{	0	,	0	,	0	,	0	}	,	//2 - Cargador
		{	1	,	1	,	1	,	1	}	,	//3 - Memoria
		{	1	,	1	,	1	,	1	}	,	//4 - Disco Duro
		{	0	,	0	,	0	,	0	}	,	//5 - Bateria
		{	1	,	1	,	1	,	1	}	,	//6 - Destornillador
		{	1	,	1	,	1	,	1	}	,	//7 - Soplador
		{	0	,	0	,	0	,	0	}	,	//8 - Antivirus
		{	1	,	1	,	1	,	1	}	,	//9 - Sistema
		{	0	,	0	,	0	,	0	}		//10 - Programas
	};

	private static string[,] l4_message = {{"Debo destaparlo","Wohhh! Tiene mucho polvo" ,"Ahora si puedo cambiar la memoria","Todo listo, excepto por un detalle","¡Ya puedo entregarlo!"}, 
		{"Esto no arregla el problema"  			 ,"Esto no arregla el problema"      ,"Esto no arregla el problema"       ,""}};

	/// <summary>
	/// ////////////////////////////////////////
	/// </summary>
	private static int[,] l5_secuence = {  {	5	,	2	,	8	}	,	 //Correcto
		{	1	,	1	,	1	}	,	//1 - Voltimetro
		{	1	,	1	,	1	}	,	//2 - Cargador
		{	1	,	1	,	1	}	,	//3 - Memoria
		{	1	,	1	,	1	}	,	//4 - Disco Duro
		{	1	,	1	,	0	}	,	//5 - Bateria
		{	1	,	1	,	1	}	,	//6 - Destornillador
		{	1	,	1	,	1	}	,	//7 - Soplador
		{	1	,	1	,	1	}	,	//8 - Antivirus
		{	1	,	1	,	1	}	,	//9 - Sistema
		{	1	,	1	,	1	}	,	//10 - Programas

	};

	private static string[,] l5_message = {{"Seguro la batería no carga bien","Es una batería nueva, pero no carga lo suficiente"  ,"Ya carga al 100%, pero se descarga muy rápido, Algún programa malicioso debe estar descargando la batería","¡Ya Funciona, ya puedo entregarlo!"}, 
		{"Esto no arregla el problema"	 ,"Esto no arregla el problema"      					,"Esto no arregla el problema"       																		,""}};



	/// <summary>
	/// Gets the secuence of the level
	/// </summary>

	private static string[,] l1_message_tut = {{"Debo medir la electricidad","Al parecer la fuente de energía no funciona","¡El computador ya funciona!"}, 
		{"Esto no arregla el problema","Esto no arregla el problema",""}};
	/// <summary>
	/// ////////////////////////////////////////
	/// </summary>
	/// <returns>The secuence.</returns>
	/// <param name="level">Level.</param>
	public  static int[,] getSecuence(int level){

		int[,] secuence = {};

		switch (level) {
		case 1:
			secuence = l1_secuence;
			break;
		case 2:
			secuence = l2_secuence;
			break;
		case 3:
			secuence = l3_secuence;
			break;
		case 4:
			secuence = l4_secuence;
			break;
		case 5:
			secuence = l5_secuence;
			break;
		}

		return secuence;

	}


	/// <summary>
	/// Gets the messages of the level
	/// </summary>
	/// <returns>The message.</returns>
	/// <param name="level">Level.</param>
	public static string[,] getMessage (int level){

		string [,] message = {};

		switch (level) {
		case 1:
			message = l1_message;
			break;
		case 2:
			message = l2_message;
			break;
		case 3:
			message = l3_message;
			break;
		case 4:
			message = l4_message;
			break;
		case 5:
			message = l5_message;
			break;
		}
		return message;
	}


	/// <summary>
	/// Gets the messages of the level
	/// </summary>
	/// <returns>The message.</returns>
	/// <param name="level">Level.</param>
	public static string[,] getMessage_tut (int level){

		string [,] message = {};

		switch (level) {
		case 1:
			message = l1_message_tut;
			break;
		/*case 2:
			message = l2_message;
			break;
		case 3:
			message = l3_message;
			break;
		case 4:
			message = l4_message;
			break;
		case 5:
			message = l5_message;
			break;*/
		}
		return message;
	}

}
