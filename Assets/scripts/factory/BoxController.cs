using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    public DropsFactory factory;
    public GameObject dropFactory;

    void Start()
    {
    }
    void OnTriggerEnter(Collider objCollider)
    {
        if(objCollider.tag == "Bullet" || objCollider.tag == "Beam" || objCollider.tag == "ShotGunBullet" || objCollider.tag == "NpcAtk")
        {
            Destroy(objCollider.gameObject);
            factory.SetDrop();
            var inst = factory.ManufactureDrops(gameObject);        
            Destroy(gameObject);
        }
    }
}
