using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gilza : MonoBehaviour
{
    public GameObject inventory;
    public GameObject gilzaItem;

    void OnMouseDown()
    {
       Debug.Log("Предмет взят.");
       if (gilzaItem.TryGetComponent(out SpriteRenderer component))
        {
            Debug.Log("found Sprite component");
            inventory.GetComponent<Inventory>().Add(2,component.sprite);
            transform.position = new Vector3(-100f, -2f, 0f);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Mouse down");
        //other.attachedRigidbody.AddForce(-0.1F * other.attachedRigidbody.velocity);
        // if (other.attachedRigidbody)
        // other.attachedRigidbody.AddForce(Vector3.up * 10);
    }
}

