using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsController : MonoBehaviour
{
    public Text scoreText;
    int currentScore = 10;

    public void ChangeScore()
    {
        currentScore--;
        Debug.Log("Score: " + currentScore.ToString());
        scoreText.text = currentScore.ToString();
        VerifyScore();
    }

    private void VerifyScore()
    {
        if (currentScore == 0)
        {
            Debug.Log("You Win!");
            SceneManager.LoadScene("CreditsScene");

        }
    }
}
