using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Lvup3 : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("lv3");
    }
}
