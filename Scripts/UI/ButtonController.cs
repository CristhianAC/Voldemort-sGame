using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    
   public void passScene(string scene)
   {
        SceneManager.LoadScene(scene);
   }
    public void salir()
    {
        Application.Quit();
    }
    
} 
