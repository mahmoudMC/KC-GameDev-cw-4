using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickbutton : MonoBehaviour
{
    int score = 0;
    public Text scoretext;
    public Text shoptext;
    int doublepoints = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        score += 1 * doublepoints;
        scoretext.text = "score: " + score;
    }

    public void shop()
    {
        if (score >= 10 * doublepoints)
        {
            score -= 10 * doublepoints;
            doublepoints++;
            shoptext.text = 10 * doublepoints + " score = double points!";
            scoretext.text = "score: " + score;
        }
    }
}
