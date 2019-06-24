using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodySpawner : MonoBehaviour
{

    public int band;
    public Sprite[] Sprite_Pic;

    public int counter = 0;

    public void OnItemClicked()
    {

        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[(++band) % Sprite_Pic.Length];
        if (band == 5)
        {
            band = 0;
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
