using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public Text score;
    public int scoreAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            int newScore = Int32.Parse(score.text) + scoreAmount;
            PlayerPrefs.SetInt("score", newScore);
            score.text = (newScore).ToString();
            Destroy(gameObject);
        }
    }
}
