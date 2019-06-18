using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodySpawner : MonoBehaviour
{

    private int rand;
    public Sprite[] Sprite_Pic;

    public int counter = 0;

    public void OnItemClicked()
    {

        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[(++rand) % Sprite_Pic.Length];

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
