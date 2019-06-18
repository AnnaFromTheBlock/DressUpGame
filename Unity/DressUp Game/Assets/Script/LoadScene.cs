using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public GameObject player;

    public void Start()
    {
        HatSpawner sn = gameObject.GetComponent<HatSpawner>();
    }


    // Update is called once per frame
    public void loadlevel(string level)
    {


                HatSpawner target = player.transform.GetComponent<HatSpawner>();
                if (target == true)
                {
                    SceneManager.LoadScene("Cowboy");
                }




        else
        {
            SceneManager.LoadScene("Nothing");
        }
        

    }
}
