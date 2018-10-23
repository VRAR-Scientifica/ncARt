using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button_script : MonoBehaviour {

    public void ButtonCLick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exited Game");
    }

    public void options_button() {

        SceneManager.LoadScene(4);

    }
}
