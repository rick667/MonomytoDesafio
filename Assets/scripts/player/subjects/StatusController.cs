using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusController : MonoBehaviour
{
    [SerializeField]private GameObject _gameOver;
    [SerializeField]private GameObject player;

    void OnEnable()
    {
        Actions.SetGameStatusNow += SetGameStatus;
    }
    void OnDisable()
    {
        Actions.SetGameStatusNow -= SetGameStatus;
    }
    void Start()
    {
        GameObject.Instantiate(player, new Vector3(3,1,2), Quaternion.identity);
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
                _gameOver.SetActive(false);
                break;
            case 1:
                _gameOver.SetActive(false);
                break;
            case 2:
                _gameOver.SetActive(true);
                break;
            default:
                break;
        }
    }
}
