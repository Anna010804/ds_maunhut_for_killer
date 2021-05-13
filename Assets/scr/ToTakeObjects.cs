using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;



public class ToTakeObjects : MonoBehaviour
 {

	public GameObject ItSelf;

	public Image image;

	
                  public GameObject gameObject2;
void OnMouseUpAsButton()
{
		Debug.Log ("взятие свечи.");
	
/*
	IMAGEMASSIV.size++;
	
	System.Array.Resize<Image> (ref IMAGEMASSIV.inventar, IMAGEMASSIV.size);
 //без увеличения размера массива оно не работало
		
IMAGEMASSIV.inventar[IMAGEMASSIV.inventar.Length - 1] = image;
	
	Destroy (ItSelf);
	
*/
 if (ItSelf.TryGetComponent(out SpriteRenderer component))
        {
            Debug.Log("found Sprite component");
            gameObject2.GetComponent<Inventory>().Add(3,component.sprite.texture);
//            gameObject2.Add(3,component.sprite.texture);
            transform.position = new Vector3(-10f, -2f, 0f);


}
   {
        Debug.Log("Mouse down");

}

}
}

