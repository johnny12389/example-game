using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("level1 1");
    }


    public void exitGame()
    {
        Application.Quit();
    }
}
