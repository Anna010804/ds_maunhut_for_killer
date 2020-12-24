using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
    public int mouseSlot;
    public SpriteRenderer[] slots;
    public Lib[] lib;
    public int draw;

    void Start() {
       draw=0;
       mouseSlot=25;
       for (int i=0; i<26; i++) {
          if (slots[i]!=null) slots[i].sprite=null;
          lib[i]=new Lib();
          lib[i].Image=null;
       };
    }

    public void Add(int itemID, Sprite itemSprite) {
        Debug.Log("adding object");
        int pos=-1;
        for (int i=0; i<26; i++) {
           if (lib[i].Image==null) {
               pos=i;
               break;
           }
        }
        if (pos>=0) {
           lib[pos].Image=itemSprite.texture;
           slots[pos].sprite=itemSprite;
        }
    }

    public void flipDraw() {
         if (draw==0) draw=1; else draw=0;
    }
/*
    void OnGUI()
    {
        if (draw==0) return;
        for (int x=0; x<5; x++)
        {
            for (int y=0; y<5; y++)
            {
                int pos=y*5+x;
                if (GUI.Button(new Rect(x*100, y*100, 100, 100), lib[pos].Image))
                {
                    if (lib[pos].Image!=null) {
                       if (mouseSlot<25) {
                          Texture t=lib[25].Image;
                          lib[25].Image=lib[pos].Image;
                          lib[pos].Image=t;
                          mouseSlot=pos;
                       } else {
                          mouseSlot=pos;
                          lib[25].Image=lib[pos].Image;
                          lib[pos].Image=null;
                       };
                    } else {
                       if (mouseSlot<25) {
                          mouseSlot=25;
                          lib[pos].Image=lib[25].Image;
                          lib[25].Image=null;
                       }
                    };
                }
            }
        }
        if (mouseSlot<25)
          if (lib[25].Image!=null)  GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 100, 100), lib[25].Image);
    }
*/
}
