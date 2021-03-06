using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    public GameObject detective;
    void Update()
    {

    }
    public void SetPosition()
    {
        transform.position = new Vector3(15f, 15f, 0f);
        detective.transform.position = new Vector3(20.2f, 12.6f, 70f);
    }
public static Transform playerTransform;

   void Awake ()
   {
     if (playerTransform = null) Destroy(gameObject);
  }
}

