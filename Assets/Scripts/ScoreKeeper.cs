using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreText;
    public int scoreCount = 0;

    [ContextMenu("Increase Score")]
    public void increaseScore()
    {
        scoreCount += 1;
        scoreText.text = scoreCount.ToString();
    }
}
