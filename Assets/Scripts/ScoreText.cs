using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public string soulNumber;
    public GameObject PlayerStats;

    void Start()
    {
        scoreText.text = "SOULS: 0";
    }

    void Update()
    {
        soulNumber = PlayerStats.GetComponent<FrogStats>().soulCount.ToString();
        scoreText.text = "SOULS: " + soulNumber;
    }
}
