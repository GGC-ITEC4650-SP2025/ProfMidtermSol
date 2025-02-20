using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int score;
    Text scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        score++;
        scoreTxt.text = "Score: " + score;
        print(score);
    }
}
