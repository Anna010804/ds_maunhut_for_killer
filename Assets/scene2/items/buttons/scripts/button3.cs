using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button3 : MonoBehaviour
{
    public GameObject detective;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPosition ()
    {
       transform.position = new Vector3(25f,0f, 0f);
       detective.transform.position = new Vector3(30.2f, -2.6f,  70f);
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
