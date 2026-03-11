using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;
    
    int myscore=0;
    // Update is called once per frame
    void Update()
    {
        scoreText.text=myscore.ToString();
        finalScoreText.text="SCORE: "+myscore.ToString();
    }
    public void AddScore(int score)
    {
        myscore=myscore+score;
    }
}
