using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DragonBones;

public class LoadScene : MonoBehaviour
{
    public GameObject hat;
    public GameObject body;

    public void Start()
    {
        HatSpawner sn = gameObject.GetComponent<HatSpawner>();   
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        
    }


    public UnityArmatureComponent player;

    // Update is called once per frame
    public void loadlevel(string level)
    {


        HatSpawner H_target = hat.transform.GetComponent<HatSpawner>();
        BodySpawner B_target = body.transform.GetComponent<BodySpawner>();
        ExtraScript E_target = body.transform.GetComponent<ExtraScript>();
        if (H_target.rand == 1 && B_target.band == 1)
        {
            SceneManager.LoadScene("Cowboy");
        }

        else if (H_target.rand == 3 && B_target.band == 2)
        {
            SceneManager.LoadScene("Water");
        }

        else if (H_target.rand == 2 && B_target.band == 4)
        {
            SceneManager.LoadScene("Space");
        }

        else if (H_target.rand == 4 && B_target.band == 3)
        {
            SceneManager.LoadScene("Bass");
        }




        else
        {
            SceneManager.LoadScene("Nothing");
        }


    }
}
