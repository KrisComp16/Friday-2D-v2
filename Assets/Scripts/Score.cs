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

    // Use this for initialization
    void Start()
    {
        
        MyText.text = "";

    }


    // Update is called once per frame
    void Update()
    {

        MyText.text = "" + Player1.playerscore;

    }



}