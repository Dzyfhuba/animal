using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    // Update is called once per frame
    public void exitgame()
    {
       Debug.Log("exitgame");
       Application.Quit();
    }
    public void Scene1() {  
        SceneManager.LoadScene("gameplay1");  
    }  
    public void Scene2() {  
        SceneManager.LoadScene(0);
    }  
}

