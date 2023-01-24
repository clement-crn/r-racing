using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    int counter = 0;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            counter += 1;
            if (counter == 2)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}

