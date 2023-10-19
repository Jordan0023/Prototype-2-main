using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{

    private int score = 0;
    private int lives = 3;
    public GameObject player;

    public Text scoreText;
    public Text livesText;


    // Start is called before the first frame update

   
    void Start()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
}

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
    }

    public void Lives(int n)
    {
        lives += n;

        if( lives <= 0)
        {
            Debug.Log("Game Over!");
            lives = 0;
            Destroy(player);
        }
        Debug.Log("Lives = " + lives);

    }

    public void Score(int n)
    {
        score += n;

        Debug.Log("Score = " + score);
    }

}
