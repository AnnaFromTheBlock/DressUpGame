using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatSpawner : MonoBehaviour
{
    private int rand;
    public Sprite[] Sprite_Pic;

    public int counter = 0;

    public void OnItemClicked()
    {
        counter++;
        if (counter % 2 == 1)
        {
            GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = Sprite_Pic[1];
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
