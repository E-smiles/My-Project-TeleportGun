using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoPlatform : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        //if(other.CompareTag("Player")) Pour gagner du stock si jamais
    {
        SceneManager.LoadScene("Level02");
    }
        if(other.tag=="Player2")
        {
            SceneManager.LoadScene("Victory");
        }
    }
    
}
