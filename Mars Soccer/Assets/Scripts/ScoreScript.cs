using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue;
    Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
    }
    private void Update()
    {
        scoreText.text = "Score :" + scoreValue;
    }
}
