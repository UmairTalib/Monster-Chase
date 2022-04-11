using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreLogic : MonoBehaviour
{
    public Text scoreText;
    public Text FinalScore;
    public float score;
    public float fscore;
    public GameObject gameover;
    void Start()
    {
        score = 0;
    }



    void Update()
    {
        if (GameObject.FindWithTag(Utils.PLAYER_TAG) && (SceneManager.GetActiveScene().name == Utils.GAMEPLAY_SCENE))
        {
            score += Time.deltaTime;
            scoreText.text = score.ToString("0");
            gameover.SetActive(false);

        }
        else if (!GameObject.FindWithTag(Utils.PLAYER_TAG) && (SceneManager.GetActiveScene().name == Utils.GAMEPLAY_SCENE))
        {
            fscore=score;
            FinalScore.text = fscore.ToString("0");
            gameover.SetActive(true);
           


        }
    }

}
