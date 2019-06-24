using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraScript : MonoBehaviour
{
    public int eand;
    public Sprite[] Sprite_Pic;

    public int counter = 0;

    public void OnItemClicked()
    {
        //counter++;
        //if (counter % 2 == 1)
        //{
        //    GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
        //}

        //if (counter % 3 == 2)
        //{
        //    GetComponent<SpriteRenderer>().sprite = Sprite_Pic[1];
        //}
        //if (counter % 5 == 3)
        //{
        //    GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand+2];
        //}

        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[(++eand) % Sprite_Pic.Length];
        if (eand == 5)
        {
            eand = 0;
        }
    }
}
