using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        ScoreTextScript.score += 50;
        Destroy(gameObject);
    }
}
