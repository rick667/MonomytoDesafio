using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField]public static int score = 0;
    [SerializeField]public static int highScore = 0;
//
    void Start()
    {
        Actions.AddScore += SwitchAddScore;
        Actions.SetHighestScore += SetHighScore;
    }
    void Update()
    {
        Actions.AddScore -= SwitchAddScore;
        Actions.SetHighestScore -= SetHighScore;
    }

    public void AddScoreByKillNpc()
    {
        score += 10;
    }

    public void AddScoreByKillPlayer()
    {
        score += 50;
    }

    public void AddScoreBySurvive()
    {
        score += 1;
    }
    public int GetHighScore(int thisHighScore)
    {
        return thisHighScore = highScore;
    }
    public void SetHighScore(int HighScore)
    {
        if(score > highScore)
        {
            HighScore = score;
        }
    }
    public void SwitchAddScore(string scoreType)
    {
        switch(scoreType)
        {
            case "Player":
                AddScoreByKillPlayer();
                break;
            case "Npc":
                AddScoreByKillNpc();
                break;
            case "Survive":
                AddScoreBySurvive();
                break;
            default:
                break;
        }
    }        
}
