using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject detective;
//    public GameObject helper;
    void Update()
    {
        
    }
    public void SetPosition ()
    {
        transform.position = new Vector3(0f, 0f, 0f);
        detective.transform.position = new Vector3(5.2f, -2.6f, 70f);
//        helper.transform.position = new Vector3(0f, 0f, 0f);
    }
public static Transform playerTransform;
   void Awake ()
   {
     if (playerTransform = null)
     {
     Destroy(gameObject);
     return;
      }
}
}
