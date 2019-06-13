using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatSpawner : MonoBehaviour
{
    private int rand;
    public Sprite[] Sprite_Pic;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
        }
    }


}
