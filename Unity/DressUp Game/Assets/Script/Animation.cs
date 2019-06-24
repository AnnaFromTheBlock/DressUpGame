using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;

public class Animation : MonoBehaviour
{
    public GameObject hat;
    public GameObject body;
    public UnityArmatureComponent player;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject.GetComponent<UnityArmatureComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        HatSpawner H_target = hat.transform.GetComponent<HatSpawner>();
        BodySpawner B_target = body.transform.GetComponent<BodySpawner>();
        ExtraScript E_target = body.transform.GetComponent<ExtraScript>();
        if (H_target.rand == 4 && B_target.band == 3)
        {
            Cool();   
        }

        else if (H_target.rand == 1 && B_target.band == 1)
        {

        }

        else
        {
            
        }
    }

    public void Cool()
    {
        player.animation.FadeIn("Cool", 0.25f, -1);
    }

    public void Country()
    {
        player.animation.FadeIn("Country", 0.25f, -1);
    }

}
