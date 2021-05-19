using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;


public class OnClick : MonoBehaviour
 {
	public GameObject golovolomka;

	public GameObject StartOfDialogButt;
	
public GameObject SatanaButton;

 
public GameObject Button;	
public GameObject dialue;
// Use this for initialization
	
public void ClickOnSatana()
{
		Debug.Log ("нажатие");
	
	golovolomka.SetActive (true);

                  Button.SetActive(true);
}
	
public void StartOfDialog()
{
		StartOfDialogButt.SetActive (true);
	
	dialue.SetActive (true);
	
	Debug.Log ("первый диалог начат");

	 Destroy (StartOfDialogButt);
}
}
