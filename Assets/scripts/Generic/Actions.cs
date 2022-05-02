using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Actions 
{
    public static Action LifeHasDiminished;
    public static Action LifeHasRestored;
    public static Action<string> WeaponHasChange;
    public static Action<int, GameObject, GameObject> FireRate;
    public static Action<GameObject, GameObject> ThisEquippedGun;
    public static Action ItsRealoaded;
    public static Action<int> IsGameOn;
    public static Action<int> IsGameOff;
    public static Action isGameOver;
    public static Action<int> SetGameStatusNow;
    public static Action<string> AddScore;
    public static Action<int> SetHighestScore;
}
