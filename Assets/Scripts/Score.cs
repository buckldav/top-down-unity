using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if it's the zeroth scene (buildIndex == 0)
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {
            // reset the score
            PlayerPrefs.SetInt("score", 0);
        }
        GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetInt("score").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
