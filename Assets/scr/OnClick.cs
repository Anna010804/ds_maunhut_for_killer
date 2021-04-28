using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {
	public GameObject golovolomka;
	public GameObject EndOfDialogButt;
	public GameObject SatanaButton;

	// Use this for initialization
	public void ClickOnSatana(){
		Debug.Log ("нажатие");
		golovolomka.SetActive (true);
	}
	public void EndOfDialog(){
		EndOfDialogButt.SetActive (false);
		SatanaButton.SetActive (true);
		Debug.Log ("первый диалог пройден");
	}
}
