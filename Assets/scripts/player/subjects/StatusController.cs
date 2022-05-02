using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusController : MonoBehaviour
{

    void OnEnable()
    {
        Actions.SetGameStatusNow += SetGameStatus;
    }
    void OnDisable()
    {
        Actions.SetGameStatusNow -= SetGameStatus;
    }
    public void SetGameStatus(int newSataus)
    {
       GameGenericsProperties.gameStatus = newSataus;
    }

    void Update()
    {
        switch(GameGenericsProperties.gameStatus)
        {
            case 0:
                break;
            case 1:
                //Actions.AddScore("Survive");
                break;
            case 2:
                //Actions.SetHighestScore(ScoreController.highScore);
                break;
            default:
                break;
        }
    }
}
