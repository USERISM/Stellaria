using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void QuitGame () {
 Application.Quit ();
 Debug.Log("Game is exiting");
 //Just to make sure its working
 }

public void StartGame(){
    SceneManager.LoadScene("Game");
}
}
