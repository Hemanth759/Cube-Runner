using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreCounter : MonoBehaviour
{
    public Transform player;
    public Text score;
    private int PreScore;

    // Start is called before the first frame update
    void Start()
    {
        PreScore = PlayerPrefs.GetInt("HighScore", 1);
        score.text = PlayerPrefs.GetInt("HighScore", 1).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = (PreScore + Convert.ToInt32(Math.Floor(player.position.z))).ToString();
        PlayerPrefs.SetInt("HighScore", int.Parse(score.text));
    }
}
