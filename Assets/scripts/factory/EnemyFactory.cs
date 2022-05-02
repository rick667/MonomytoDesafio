using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField]private GameObject finalProduct;
    private float[] _xSpot = {-30f, 30f, 0};
    private float[] _zSpot = {20, -15, 0};
    private string gun;
    private int randomXIndex;
    private int randomYIndex;
    private float randomGunSpot;
    public GameObject pistol; 
    

    public Vector3 finalSpot;


    void Start()
    {
        
    }
    void Update()
    {
        RandomicSpot();
        SetSpawn();

    }
    public Vector3 SetSpawn()
    {
        if(_xSpot[randomXIndex] == 2 && _zSpot[randomYIndex] != 2)
        {
            return finalSpot = new Vector3(0, 1f, _zSpot[randomYIndex]);
        }
        else if(_zSpot[randomXIndex] == 2 || _xSpot[randomXIndex] != 2 )
        {
            return finalSpot = new Vector3(_xSpot[randomXIndex], 1f, 0);
        }
        else
        {
            RandomicSpot();
            return finalSpot = new Vector3(_xSpot[randomXIndex], 1f, _zSpot[randomYIndex]);
        }
    }
    public void RandomicSpot()
    {
        randomXIndex = Random.Range(0, 2);
        randomYIndex = Random.Range(0, 2);
    }
    public GameObject ManufactureEnemy()
    {
        GameObject newEnemy = GameObject.Instantiate(finalProduct, finalSpot, Quaternion.identity);
        //SetGun();
        return newEnemy;
    }
}
