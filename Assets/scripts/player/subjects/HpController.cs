using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpController : PlayerMovementController
{
    void Start()
    {
        Actions.LifeHasDiminished += TakeDamage;
        Actions.LifeHasRestored += RestoreHp;
        Actions.isGameOver += GameOver;
    }
    private void OnDisable()
    {
        Actions.LifeHasDiminished -= TakeDamage;
        Actions.LifeHasRestored -= RestoreHp;
        Actions.isGameOver -= GameOver;
    }
    void TakeDamage()
    {
        hp -= 1;
    }
    void RestoreHp()
    {
        if(hp < 5)
        {
            hp += 5;
        }
        else
        {
            hp += (10 - hp);
        }
    }
    void GameOver()
    {
        if(hp <= 0)
        {
            Actions.SetGameStatusNow(1);
        }
    }
}
