using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Provides control of play and quit buttons

public class MenuScript : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1);

    }
        public void QuitButton()
    {
        Application.Quit();
    }

}
