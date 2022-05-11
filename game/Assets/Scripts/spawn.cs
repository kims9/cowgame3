using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    //This allows us to trasnfer scenes upon colliding 
    void OnTriggerEnter(Collider cowscene)
    {
        Debug.Log("hello cow");
        if (cowscene.tag == "Cow")
        { 
            SceneManager.LoadScene(1);
            //SceneManager.LoadScene(2);
            //SceneManager.LoadScene(3);
        }

      
    }
}