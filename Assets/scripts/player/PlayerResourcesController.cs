using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerResourcesController : Characters
{
    public GameObject attack;

    void Start()
    {
    }
    void Update()
    {
        if(GameGenericsProperties.gameStatus == 2)
        {
            hp = 10;
        }
    }

    public void OnTriggerEnter(Collider objCollider)
    {
        if(objCollider.tag == "NpcAtk")
        {
            hp -= 1;
            Destroy(objCollider.gameObject);
        }
    }
}
