using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Player1;

public class Score : MonoBehaviour
{


    
    public Text MyText;
    private int score;
    //private Player1;
    public int playerscore = Player1.playerscore;
    public int highscore;

    // Use this for initialization
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        MyText.text = "";

    }


    // Update is called once per frame
    void Update()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);

        MyText.text = "Score = " + Player1.playerscore + " " +
            "Highscore = " + highscore;

        if (Player1.playerscore > highscore)
        {
            highscore = Player1.playerscore;

            SetHighscore("highscore", highscore);
        }
        else
        {
            return;
        }

        
        void SetHighscore(string name, int Value)
        {
            PlayerPrefs.SetInt(name, Value);
        }
        
    }



}