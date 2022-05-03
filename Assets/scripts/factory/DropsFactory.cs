using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropsFactory : MonoBehaviour
{
    [SerializeField]private GameObject finalProduct;
    [SerializeField]private GameObject[] Guns;

    public Vector3 finalSpot;
    public GameObject FinalDrop;
    public int randomDrop; 

    void Start()
    {
        
    }
    void Update()
    {
        SetSpawn();

    }
    public Vector3 SetSpawn()
    {
        return finalSpot = new Vector3(Random.Range(-18, 18), 22f, Random.Range(-7, 9));
    }
    public GameObject ManufactureBox()
    {
        GameObject newBox = GameObject.Instantiate(finalProduct, finalSpot, Quaternion.identity);
        //SetGun();
        return newBox;
    }
    public GameObject ManufactureDrops(GameObject box)
    {
        GameObject newGun = GameObject.Instantiate(FinalDrop, new Vector3
        (box.transform.position.x + (Random.Range(-1, 1)), 1, box.transform.position.z + (Random.Range(-1, 1))), Quaternion.identity);
        //SetGun();
        return newGun;
    }
    public void SetDrop()
    {
        randomDrop = Random.Range(0,3);
        FinalDrop = Guns[randomDrop];
    }
}
