using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToTakeObjects : MonoBehaviour {

	public GameObject ItSelf;
	public Image image;

	void OnMouseUpAsButton(){
		Debug.Log ("взятие свечи.");
		IMAGEMASSIV.size++;
		System.Array.Resize<Image> (ref IMAGEMASSIV.inventar, IMAGEMASSIV.size); //без увеличения размера массива оно не работало
		IMAGEMASSIV.inventar[IMAGEMASSIV.inventar.Length - 1] = image;
		Destroy (ItSelf);
	}

}
