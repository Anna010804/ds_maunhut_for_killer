using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class script1 : MonoBehaviour
 {
	public static GameObject[] golov = new GameObject [10];

	public static int CountOfSolveGames = 0;
	
public static bool IsGameSolved = false;

	
public GameObject StartOfDialogButt;

public GameObject Dialue;
// Use this for initialization
	
void Start ()
 {
		
golov[0] = GameObject.Find ("golovolomka");

		golov[0].SetActive (false);

	}

	void Update()
{
		
if(CountOfSolveGames == 1 && IsGameSolved)
{
			golov [0].SetActive (false);

		Debug.Log ("вывод второго диалога");
	
		IsGameSolved = false;

                                     	StartOfDialogButt.SetActive (true);

	}
	  
	//здесь остальные ифы для включения последующих диалогов
	
	//CountOfGameSolved и IsGameSolved изменяются в скрипте GameController на 249 строчке
	
}

}
