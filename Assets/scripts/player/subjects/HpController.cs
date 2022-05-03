using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpController : PlayerResourcesController
{
    [SerializeField] GunController power;
    [SerializeField] GameObject player;
    void Start()
    {
        Actions.LifeHasDiminished += TakeDamage;
        Actions.LifeHasRestored += RestoreHp;
        Actions.isGameOver += GameOver;
        player = GameObject.FindWithTag("Player");
        power = new GunController();
    }
    void Update()
    {
        GameOver();
    }
    private void OnDisable()
    {
        Actions.LifeHasDiminished -= TakeDamage;
        Actions.LifeHasRestored -= RestoreHp;
        //Actions.isGameOver -= GameOver;
    }
    void TakeDamage()
    {
        hp -= power.gunDamage;
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
            Actions.SetGameStatusNow(2);
        }
    }
}
