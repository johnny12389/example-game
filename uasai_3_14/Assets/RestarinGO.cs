using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestarinGO : MonoBehaviour
{
    public GameObject Gameover;
    public void RestartButton()
    {

        SceneManager.LoadScene("level1 1");


    }
}
