using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HeartText : MonoBehaviour
{
    Text text;
    public static int life = 5;
    void Start()
    {
        life = 5;
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = life.ToString();
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
