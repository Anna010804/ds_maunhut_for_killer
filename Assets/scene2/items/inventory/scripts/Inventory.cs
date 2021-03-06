using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{

    public int mouseSlot;
    public Lib lib;
    public int draw;

       void Start() {
       draw=0;
       mouseSlot=26;
       for (int i=0; i<26; i++) lib.Images[i]=null;
    }

    public void Add(int i, Texture t) {
        Debug.Log("adding object");
        lib.Images[0]=t;
    }

    public void flipDraw() {
         if (draw==0) draw=1; else draw=0;
    }

    void OnGUI()
    {
        if (draw==0) return;
        for (int x=0; x<5; x++)
        {
            for (int y=0; y<5; y++)
            {
                int pos=y*5+x;
                if (GUI.Button(new Rect(x*100, y*100, 100, 100), lib.Images[pos]))
                {
                    if (lib.Images[pos]!=null) {
                       if (mouseSlot<25) {
                          Texture t=lib.Images[25];
                          lib.Images[25]=lib.Images[pos];
                          lib.Images[pos]=t;
                          mouseSlot=pos;
                       } else {
                          mouseSlot=pos;
                          lib.Images[25]=lib.Images[pos];
                          lib.Images[pos]=null;
                       };
                    } else {
                       if (mouseSlot<25) {
                          mouseSlot=25;
                          lib.Images[pos]=lib.Images[25];
                          lib.Images[25]=null;
                       }
                    };
                }
            }
        }
        if (mouseSlot<25)
          if (lib.Images[25]!=null)  GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 100, 100), lib.Images[25]);
    }


}
