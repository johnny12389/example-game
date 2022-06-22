using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        HeartText.life += 1;
        Playercont.life += 1;
        Destroy(gameObject);    
     }
}
