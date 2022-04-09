using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Socre : MonoBehaviour
{
    Text ScoreText;
    
    public int Points { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int addPoints)
    {
        Points += addPoints; //현재 점수 더함

        ScoreText.text = string.Format("점수:{0:D3}", Points);
    }
}
