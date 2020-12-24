using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnfx : MonoBehaviour
{   
     public AudioSource player;
     public AudioClip clickfx;
  
   
    public void ClickSound()

{  
   if (player!=null) {
       player.PlayOneShot(clickfx, 1.0F);
   }
}
   
        
    
}
