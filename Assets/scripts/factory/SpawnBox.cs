using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    [SerializeField] public float spawnRatePerMinute = 30;
    public static int currentCount = 0;
    [SerializeField] public DropsFactory factory;
 
    void Update()
    {
        var targetCount = Time.time * (spawnRatePerMinute / 60);
        while (targetCount > currentCount)
        {
            var inst = factory.ManufactureBox();
            currentCount++;
        }
    }
}
