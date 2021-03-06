using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] public float spawnRatePerMinute = 10;
    public static int currentCount = 0;
    [SerializeField] private EnemyFactory factory;
 
    void Update()
    {
        var targetCount = Time.time * (spawnRatePerMinute / 60);
        while (targetCount > currentCount)
        {
            var inst = factory.ManufactureEnemy();
            currentCount++;
        }
    }
}
