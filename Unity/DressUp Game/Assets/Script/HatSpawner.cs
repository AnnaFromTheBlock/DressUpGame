using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatSpawner : MonoBehaviour
{
    public int rand;
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

        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[(++rand) % Sprite_Pic.Length];
        if (rand == 5)
        {
            rand = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


}
