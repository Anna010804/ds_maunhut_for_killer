using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onclick : MonoBehaviour {
	public int NumberOfMenuScene;//номер меню-сцены в билде
	public GameObject Panel; //панель, с помощью которой происходит затухание экрана
	public GameObject ToMenuButton;

	public void FirstButton(){
		Debug.Log ("нажатие на 1 кнопку");
		Panel.SetActive (true);
		ToMenuButton.SetActive (true);
	}

	public void SecondButton(){
		Debug.Log ("нажатие на 2 кнопку");
		Panel.SetActive (true);
		ToMenuButton.SetActive (true);
	}
	public void ThirdButton(){
		Debug.Log ("нажатие на 3 кнопку");
		Panel.SetActive (true);
		ToMenuButton.SetActive (true);
	}

	public void ToMenu(){
		Debug.Log ("переход в меню");
		SceneManager.LoadScene ("Scenes/menu");
	}

	//если затухание экрана не правильно работает, то у канваса, где есть Panel поставьте orderInLayer больше, и у другого канваса, где кнопка "в меню" orderInLayer на 1 больше, чем у предыдущего канваса 
}
