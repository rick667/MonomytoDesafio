using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAmmo : MonoBehaviour
{

    void OnTriggerEnter(Collider objCollider)
    {
        if(objCollider.tag == "Bullet" || objCollider.tag == "Beam" || objCollider.tag == "ShotGunBullet" || objCollider.tag == "NpcAtk")
        {
            Destroy(objCollider.gameObject);
        }
    }
}
