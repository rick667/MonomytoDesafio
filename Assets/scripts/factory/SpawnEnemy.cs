using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private float spawnRatePerMinute = 30;
    public static int currentCount = 0;
    private int _maxEnemy = 10;
    [SerializeField] private EnemyFactory factory;
 
    void Update()
    {
        var targetCount = Time.time * (spawnRatePerMinute / 60);
        while (targetCount > currentCount)
        {
            if(currentCount < _maxEnemy)
            {
                var inst = factory.ManufactureEnemy();
                currentCount++;
            }else return;
        }
    }
}
